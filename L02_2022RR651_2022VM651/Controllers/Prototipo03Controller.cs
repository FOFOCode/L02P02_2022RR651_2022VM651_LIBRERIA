using L02_2022RR651_2022VM651.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02_2022RR651_2022VM651.Controllers
{
    public class Prototipo03Controller : Controller
    {
        public readonly libreriaDbContext _libreriaDbContext;

        public Prototipo03Controller(libreriaDbContext libreriaDbContext)
        {
            _libreriaDbContext = libreriaDbContext;
        }

        public IActionResult Index()
        {
            return View("~/Views/Prototipos/Prototipo03.cshtml");
        }
    }
}
