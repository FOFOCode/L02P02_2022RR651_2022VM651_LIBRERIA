using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace L02_2022RR651_2022VM651.Models
{
    public class pedido_detalle
    {
        [Key]
        public int id { get; set; }
        public int id_pedido { get; set; }
        public int id_libro { get; set; }
        [Display(Name = "Creado en")]
        public DateTime created_at { get; set; }
    }
}
