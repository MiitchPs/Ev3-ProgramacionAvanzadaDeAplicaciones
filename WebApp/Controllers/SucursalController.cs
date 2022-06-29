using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SucursalController : Controller
    {
        private readonly AppDbContext _context;

        public SucursalController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index() // Views - Marcas - Index
        {
            var Sucursales = _context.tblSucursales.ToList();
            return View(Sucursales);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Sucursal S)
        {
            if (S == null) return View();

            if (ModelState.IsValid)
            {
                _context.Add(S);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(S);
        }

        [HttpGet]
        public IActionResult Edit(int SucursalId)
        {
            var Sucursal = _context.tblTipos.FirstOrDefault(m => m.Id == SucursalId);
            if (Sucursal == null) return NotFound();
            else
            {
                return View(Sucursal);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Sucursal Sucursal)
        {
            if (ModelState.IsValid)
            {
                _context.Update(Sucursal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Sucursal);
        }


        [HttpGet]
        public IActionResult Delete(int SucursalId)
        {
            var Sucursal = _context.tblTipos.FirstOrDefault(s => s.Id == SucursalId);
            if (Sucursal == null) return NotFound();
            else
            {
                return View(Sucursal);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Sucursal Sucursal)
        {
            _context.Remove(Sucursal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




    }
}
