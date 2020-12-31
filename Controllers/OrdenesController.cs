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
using Microsoft.AspNetCore.Http;
using System.Dynamic;
using Newtonsoft.Json;

namespace norcam.Controllers
{
    public class OrdenesController : Controller
    {

        private readonly ApplicationDbContext _context;

        private List<Ordenes> listOrdenes= new List<Ordenes>();

        private List<Cliente> listCliente = new List<Cliente>();

        public OrdenesController(ApplicationDbContext context)
        {
            _context = context;
            listOrdenes=_context.Ordenes.ToList();
            listCliente=_context.Cliente.ToList();
        }

        public IActionResult Index()
        {
            var status=HttpContext.Session.GetString("State");
            if(status!=null){
                var user = JsonConvert.DeserializeObject<Usuario>(HttpContext.Session.GetString("SessionUser"));
                var tipo = user.Tipo;
                if(tipo=="A"){
                    dynamic modelo= new ExpandoObject();
                    modelo.Cliente=listCliente;
                    modelo.Ordenes=listOrdenes;
                    return View("Index",modelo);
                }else{
                    HttpContext.Session.Clear();
                    return RedirectToAction("Index","Login");
                }
            }else{
                return RedirectToAction("Index","Login");
            } 
        }

        public IActionResult Nuevo()
        {
            return View();
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
        
        private bool OrdenesExists(int id)
        {
            return _context.Ordenes.Any(e => e.id == id);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orden = await _context.Ordenes.FindAsync(id);
            if (orden == null)
            {
                return NotFound();
            }
            return View(orden);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,fec_rec,cod_cliente,razon_social,contenido")] Ordenes ordenes)
        {
            if (id != ordenes.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordenes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenesExists(ordenes.id))
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
            return View(ordenes);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orden = await _context.Ordenes
                .FirstOrDefaultAsync(m => m.id == id); 
            if (orden == null)
            {
                return NotFound();
            }

            return View(orden);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orden = await _context.Ordenes.FindAsync(id);
            _context.Ordenes.Remove(orden);
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