using Microsoft.EntityFrameworkCore;
using AppEntityCore.Models;

namespace AppEntityCore.Datos
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> opciones) : base(opciones)
        {

        }
        public DbSet<Articulo> articulo { get; set; }
        public DbSet<Categoria>  categoria { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<Pedido> pedido { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<DetalleUsuario> usuariosDetalle { get; set; }
        public DbSet<Etiqueta> etiqueta { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticuloEtiqueta>().
                HasKey(ae => new { ae.EtiquetaId, ae.ArticuloId });
        }
    }
}
