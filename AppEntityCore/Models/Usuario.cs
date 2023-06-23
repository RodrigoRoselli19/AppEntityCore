using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppEntityCore.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        [NotMapped]
        public int Edad { get; set; }
        [Display(Name = "Correo electronico")]
        [RegularExpression(@"^[a - z0 - 9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$)")]
        public string? Mail { get; set; }
        public string? Password { get; set; }
        public int? Telefono { get; set; }
        [ForeignKey("DetalleUsuario")]
        public int DetalleUsuarioId { get; set; }
        public DetalleUsuario? DetalleUsuario { get; set; }
    }
}
