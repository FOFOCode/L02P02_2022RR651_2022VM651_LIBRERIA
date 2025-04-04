﻿using L02_2022RR651_2022VM651.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace L02_2022RR651_2022VM651.Controllers
{
    public class Prototipo02Controller : Controller
    {
        private readonly libreriaDbContext _context;

        public Prototipo02Controller(libreriaDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int idAutor)
        {
            if (idAutor == 0)
            {
                return RedirectToAction("Index", "Prototipo01"); // Si no hay autor, redirigir a la selección
            }

            var libros = await _context.libros
                .Where(l => l.id_autor == idAutor)
                .ToListAsync();

            ViewBag.AutorSeleccionado = await _context.autores
                .Where(a => a.id == idAutor)
                .Select(a => a.autor)
                .FirstOrDefaultAsync();

            return View("~/Views/Prototipos/Prototipo02.cshtml", libros);
        }
    }
}
