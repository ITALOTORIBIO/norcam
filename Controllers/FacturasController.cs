using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                objFactura.Respuesta1 = objFactura.adval+objFactura.reintegro+objFactura.ipm;
                objFactura.total_liq=objFactura.Respuesta1;
                objFactura.igv_fact = (objFactura.gasto_admin+objFactura.gasto_ope+objFactura.sup_cont+objFactura.comision)*0.18;
                objFactura.total_neto=objFactura.igv_fact+objFactura.gasto_admin+objFactura.gasto_ope+objFactura.sup_cont+objFactura.comision;
                _context.Add(objFactura);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objFactura);
        }

        private bool FacturaExists(int id)
        {
            return _context.Factura.Any(e => e.id == id);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Factura.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            return View(factura);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("cod_orden,archivo,fec_fac,id,total_neto")] Facturas factura)
        {
            if (id != factura.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturaExists(factura.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(factura);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Factura
                .FirstOrDefaultAsync(m => m.id == id); 
            if (factura == null)
            {
                return NotFound();
            }

            return View(factura);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var factura = await _context.Factura.FindAsync(id);
            _context.Factura.Remove(factura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalle(int id)
        {            
            var factura = _context.Factura.Where(m => m.id == id).FirstOrDefault();             
            return PartialView("Detalle",factura);
        }

    }
}