using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class MarcasController : Controller
    {
        private readonly AppDbContext _context;

        public MarcasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index() // Views - Marcas - Index
        {
            var marcas = _context.tblMarcas.ToList();
            return View(marcas);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Marca M)
        {
            if (M == null) return View();

            if (ModelState.IsValid)
            {
                _context.Add(M);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(M);
        }

        [HttpGet]
        public IActionResult Edit(int IdMarca)
        {
            var Marca = _context.tblMarcas.FirstOrDefault(m => m.Id == IdMarca);
            if (Marca == null) return NotFound();
            else
            {
                return View(Marca);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Marca Marca)
        {
            if (ModelState.IsValid)
            {
                _context.Update(Marca);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Marca);
        }


        [HttpGet]
        public IActionResult Delete(int IdMarca)
        {
            var Marca = _context.tblMarcas.FirstOrDefault(m => m.Id == IdMarca);
            if (Marca == null) return NotFound();
            else
            {
                return View(Marca);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Marca Marca)
        {
            _context.Remove(Marca);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
