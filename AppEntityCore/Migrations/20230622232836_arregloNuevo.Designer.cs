﻿// <auto-generated />
using System;
using AppEntityCore.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppEntityCore.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230622232836_arregloNuevo")]
    partial class arregloNuevo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppEntityCore.Models.Articulo", b =>
                {
                    b.Property<int>("IdArticulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdArticulo"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TituloArticulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdArticulo");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("AppEntityCore.Models.ArticuloEtiqueta", b =>
                {
                    b.Property<int>("EtiquetaId")
                        .HasColumnType("int");

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.HasKey("EtiquetaId", "ArticuloId");

                    b.HasIndex("ArticuloId");

                    b.ToTable("ArticuloEtiqueta");
                });

            modelBuilder.Entity("AppEntityCore.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("AppEntityCore.Models.DetalleUsuario", b =>
                {
                    b.Property<int>("DetalleUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleUsuarioId"), 1L, 1);

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<string>("Deporte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mascota")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetalleUsuarioId");

                    b.ToTable("DetalleUsuario");
                });

            modelBuilder.Entity("AppEntityCore.Models.Etiqueta", b =>
                {
                    b.Property<int>("EtiquetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EtiquetaId"), 1L, 1);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EtiquetaId");

                    b.ToTable("Etiquetas");
                });

            modelBuilder.Entity("AppEntityCore.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("FechaPedido")
                        .HasColumnType("datatime");

                    b.HasKey("Id");

                    b.ToTable("pedido");
                });

            modelBuilder.Entity("AppEntityCore.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descripcion_Producto");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("AppEntityCore.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DetalleUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DetalleUsuarioId")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("AppEntityCore.Models.Articulo", b =>
                {
                    b.HasOne("AppEntityCore.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("AppEntityCore.Models.ArticuloEtiqueta", b =>
                {
                    b.HasOne("AppEntityCore.Models.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppEntityCore.Models.Etiqueta", "Etiqueta")
                        .WithMany()
                        .HasForeignKey("EtiquetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articulo");

                    b.Navigation("Etiqueta");
                });

            modelBuilder.Entity("AppEntityCore.Models.Producto", b =>
                {
                    b.HasOne("AppEntityCore.Models.Categoria", "Categoria")
                        .WithMany("productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("AppEntityCore.Models.Usuario", b =>
                {
                    b.HasOne("AppEntityCore.Models.DetalleUsuario", "DetalleUsuario")
                        .WithOne("Usuario")
                        .HasForeignKey("AppEntityCore.Models.Usuario", "DetalleUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetalleUsuario");
                });

            modelBuilder.Entity("AppEntityCore.Models.Categoria", b =>
                {
                    b.Navigation("productos");
                });

            modelBuilder.Entity("AppEntityCore.Models.DetalleUsuario", b =>
                {
                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
