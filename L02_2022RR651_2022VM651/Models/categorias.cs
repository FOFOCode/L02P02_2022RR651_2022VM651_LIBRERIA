using System.ComponentModel.DataAnnotations;

namespace L02_2022RR651_2022VM651.Models
{
    public class categorias
    {
        [Key]
        [Display(Name = "Id de la categoria")]
        public int id { get; set; }
        [Display(Name = "Categoria")]
        public string categoria { get; set; }
    }
}
