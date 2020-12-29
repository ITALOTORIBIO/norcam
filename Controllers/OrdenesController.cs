using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using norcam.Models;
using norcam.Data;
namespace norcam.Controllers
{
    public class OrdenesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public OrdenesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var orden = _context.Ordenes.ToList();
            return View(orden);
        }

        [HttpPost]
        public IActionResult Nuevo(Ordenes objOrden)
        {
            if (ModelState.IsValid) {

                _context.Add(objOrden);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objOrden);
        }

        public IActionResult Nuevo()
        {
            return View();
        }
        
    }
}