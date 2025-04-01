using System.ComponentModel.DataAnnotations;

namespace L02_2022RR651_2022VM651.Models
{
    public class autores
    {
        [Key]
        [Display(Name = "Id del autor")]
        public int id { get; set; }
        [Display(Name = "Autor")]
        public string? autor { get; set; }
    }
}
