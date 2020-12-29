using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using norcam.Data;
using norcam.Models;

namespace norcam.Controllers
{
    public class FacturasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FacturasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var factura = _context.Factura.ToList();
            return View(factura);
        }
        public IActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Nuevo(Facturas objFactura)
        {
            if (ModelState.IsValid) {

                _context.Add(objFactura);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objFactura);
        }
    }
}