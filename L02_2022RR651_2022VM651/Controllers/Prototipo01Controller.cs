using L02_2022RR651_2022VM651.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02_2022RR651_2022VM651.Controllers
{
    public class Prototipo01Controller : Controller
    {
        public readonly libreriaDbContext libreriaDbContext;

        public IActionResult Index()
        {
            return View();
        }
    }
}
