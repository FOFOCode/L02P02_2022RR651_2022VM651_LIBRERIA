using L02_2022RR651_2022VM651.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02_2022RR651_2022VM651.Controllers
{
    public class Prototipo01Controller : Controller
    {
        public readonly libreriaDbContext _libreriaDbContext;

        public Prototipo01Controller(libreriaDbContext libreriaDbContext)
        {
            _libreriaDbContext = libreriaDbContext;
        }

        public IActionResult Index()
        {
            var listaDeAutores = _libreriaDbContext.auto.ToList();
            ViewData["listadoAutores"] = listaDeAutores;
            return View();
        }
    }
}
