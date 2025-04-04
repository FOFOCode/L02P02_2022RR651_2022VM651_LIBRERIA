﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L02_2022RR651_2022VM651.Models
{
    public class comentarios_libros
    {
        [Key]
        public int id { get; set; }
        public int id_libro { get; set; }

        [Column("comentarios")] 

        public string comentario { get; set; }
        public string usuario { get; set; }
        [Display(Name = "Creado en")]
        public DateTime created_at { get; set; }
    }
}
