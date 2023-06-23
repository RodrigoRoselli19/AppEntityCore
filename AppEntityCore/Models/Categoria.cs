using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }
        public ICollection<Producto>? productos { get; set; }

    }
}
