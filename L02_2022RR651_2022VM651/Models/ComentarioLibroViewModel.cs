using System.ComponentModel.DataAnnotations;

namespace L02_2022RR651_2022VM651.Models
{
    public class ComentarioLibroViewModel
    {
        public int IdLibro { get; set; }

        [Display(Name = "Nombre del Libro")]
        public string NombreLibro { get; set; }

        [Display(Name = "Autor")]
        public string NombreAutor { get; set; }

        public List<ComentarioDetalleViewModel> Comentarios { get; set; }

        public NuevoComentarioViewModel NuevoComentario { get; set; }
    }

    public class ComentarioDetalleViewModel
    {
        public string Usuario { get; set; }

        [Display(Name = "Comentario")]
        public string Comentario { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime FechaCreacion { get; set; }
    }

    public class NuevoComentarioViewModel
    {
        [Required]
        public int IdLibro { get; set; }

        [Required]
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }

        [Required]
        [Display(Name = "Comentario")]
        public string Comentario { get; set; }
    }
}
