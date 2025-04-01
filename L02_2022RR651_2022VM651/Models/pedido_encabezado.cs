using System.ComponentModel.DataAnnotations;

namespace L02_2022RR651_2022VM651.Models
{
    public class pedido_encabezado
    {
        [Key]
        [Display(Name = "Id del encabezado")]
        public int id { get; set; }
        public int id_cliente { get; set; }
        [Display(Name = "Cantidad de libros")]
        public int cantidad_libros { get; set; }
        [Display(Name = "Total")]
        public double total { get; set; }
    }
}
