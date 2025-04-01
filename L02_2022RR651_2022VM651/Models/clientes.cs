using System.ComponentModel.DataAnnotations;

namespace L02_2022RR651_2022VM651.Models
{
    public class clientes
    {
        [Key]
        [Display(Name = "Id del cliente")]
        public int id { get; set; }
        [Display(Name = "Nombre del cliente")]
        public string? nombre { get; set; }
        [Display(Name = "Apellido del cliente")]
        public string? apellido { get; set; }
        [Display(Name = "Direccion")]
        public string? direccion { get; set; }
        [Display(Name = "Creado en")]
        public DateTime created_at { get; set; }

    }
}
