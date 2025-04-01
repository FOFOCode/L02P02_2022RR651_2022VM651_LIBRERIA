using System.ComponentModel.DataAnnotations;

namespace L02_2022RR651_2022VM651.Models
{
    public class libros
    {
        [Key]
        [Display(Name = "Id del libro")]
        public int id { get; set; }
        [Display(Name = "Nombre del nombre")]
        public string nombre { get; set; }
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }
        [Display(Name = "Url de la imagen")]
        public string url_imagen { get; set; }
        public int id_autor { get; set; }
        public int id_categoria { get; set; }
        [Display(Name = "Precio")]
        public double precio { get; set; }
        [Display(Name = "Estado")]
        public string estado { get; set; }
    }
}
