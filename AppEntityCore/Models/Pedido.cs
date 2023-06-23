using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppEntityCore.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "datatime")]
        public DateTime FechaPedido { get; set; }
    }
}
