using L02_2022RR651_2022VM651.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace L02_2022RR651_2022VM651.Controllers
{
    public class Prototipo01Controller : Controller
    {
        public readonly libreriaDbContext _libreriaDbContext;

        public Prototipo01Controller(libreriaDbContext libreriaDbContext)
        {
            _libreriaDbContext = libreriaDbContext;
        }

        // Método GET para obtener todos los autores
        public IActionResult Index()
        {
            var listadoDeAutores = (from a in _libreriaDbContext.autores
                                    select a).ToList();

            ViewData["listadoDeAutores"] = listadoDeAutores;

            return View("~/Views/Prototipos/Prototipo01.cshtml");
        }
    }
}

