using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using norcam.Models;
using norcam.Data;
using Microsoft.EntityFrameworkCore;

namespace norcam.Controllers
{
    public class RecibosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecibosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var recibo = _context.Recibos.ToList();
            return View(recibo);
        }

        public IActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Recibos objRecibo)
        {
            if (ModelState.IsValid) {

                _context.Add(objRecibo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objRecibo);
        }

        private bool RecibosExists(int id)
        {
            return _context.Recibos.Any(e => e.id == id);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recibo = await _context.Recibos.FindAsync(id);
            if (recibo == null)
            {
                return NotFound();
            }
            return View(recibo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,fec_pago,doc_cob,factura")] Recibos recibos)
        {
            if (id != recibos.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recibos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecibosExists(recibos.id))
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
            return View(recibos);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recibo = await _context.Recibos
                .FirstOrDefaultAsync(m => m.id == id); 
            if (recibo == null)
            {
                return NotFound();
            }

            return View(recibo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recibo = await _context.Recibos.FindAsync(id);
            _context.Recibos.Remove(recibo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalle(int id)
        {            
            var cliente = _context.Ordenes.Where(m => m.id == id).FirstOrDefault();             
            return PartialView("Detalle",cliente);
        }

    }
}