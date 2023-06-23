using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
#nullable disable
    [Table("Articulos")]
    public class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }
        public string TituloArticulo { get; set; }
        public string Descripcion { get; set; }
        public string fecha { get; set; }
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }


        public Categoria Categoria { get; set; }
    }
}
