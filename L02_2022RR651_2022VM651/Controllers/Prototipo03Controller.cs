using L02_2022RR651_2022VM651.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace L02_2022RR651_2022VM651.Controllers
{
    public class Prototipo03Controller : Controller
    {
        private readonly libreriaDbContext _libreriaDbContext;

        public Prototipo03Controller(libreriaDbContext libreriaDbContext)
        {
            _libreriaDbContext = libreriaDbContext;
        }

        public IActionResult Index(int idLibro)
        {
            var libro = _libreriaDbContext.libros.FirstOrDefault(l => l.id == idLibro);
            if (libro == null)
            {
                return NotFound();
            }

            var comentarios = _libreriaDbContext.comentarios_libros.Where(c => c.id_libro == idLibro).ToList();
            var autor = _libreriaDbContext.autores.FirstOrDefault(a => a.id == libro.id_autor);

            ViewBag.AutorSeleccionado = autor?.autor ?? "Autor Desconocido";
            ViewBag.LibroSeleccionado = libro.nombre;
            ViewBag.IdLibro = idLibro;

            return View("~/Views/Prototipos/Prototipo03.cshtml", comentarios);
        }
        [HttpPost]
        public IActionResult AgregarComentario(int idLibro, string contenido)
        {
            if (string.IsNullOrWhiteSpace(contenido))
            {
                TempData["Error"] = "El comentario no puede estar vacío.";
                return RedirectToAction("Index", new { idLibro });
            }

            var nuevoComentario = new comentarios_libros
            {
                id_libro = idLibro,
                comentario = contenido,
                usuario = "Usuario Anónimo",
                created_at = DateTime.Now
            };

            _libreriaDbContext.comentarios_libros.Add(nuevoComentario);
            _libreriaDbContext.SaveChanges();

            // Redirigir a la página con la barra de progreso actualizada
            TempData["ComentarioAgregado"] = true;
            return RedirectToAction("Index", new { idLibro });
        }



    }
}
