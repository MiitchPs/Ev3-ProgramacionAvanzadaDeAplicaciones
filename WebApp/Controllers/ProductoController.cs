using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProductoController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public ProductoController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public IActionResult Index()
        {
            var Producto = _context.tblProductos
                .Include(p => p.Marca)
                .Include(p => p.Tipo)
                .Include(p => p.Categoria)
                .Include(p => p.Sucursal)
                .ToList();

            return View(Producto);
        }

        public IActionResult CrearProducto()
        {
            ViewData["Marcas"] = new SelectList(_context.tblMarcas.ToList(), "Id", "Name");
            ViewData["Tipos"] = new SelectList(_context.tblTipos.ToList(), "Id", "Name");
            ViewData["Categorias"] = new SelectList(_context.tblCategorias.ToList(), "Id", "Name");
            ViewData["Sucursales"] = new SelectList(_context.tblCategorias.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearProducto(Producto P)
        {
            if (ModelState.IsValid)
            {
                if (P.ImagenFile == null) P.ImagenUrl = "no-disponible.png";
                else
                {
                    string wwwRootPath = _environment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(P.ImagenFile.FileName);
                    string extension = Path.GetExtension(P.ImagenFile.FileName);
                    P.ImagenUrl = fileName + DateTime.Now.ToString("ddMMyyyyHHmmss") + extension; //foto08062022131545.png 

                    string path = Path.Combine(wwwRootPath + "/img/" + P.ImagenUrl);

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await P.ImagenFile.CopyToAsync(fileStream);
                    }
                }
                _context.Add(P);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(P);
            }
        }

        [HttpGet]
        public IActionResult Edit(int IdProducto)
        {
            var P = _context.tblProductos.FirstOrDefault(p => p.Id == IdProducto);
            if (P == null) return NotFound();
            else
            {
                return View(P);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Producto P)
        {
            if (ModelState.IsValid)
            {
                _context.Update(P);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(P);
        }

        [HttpGet]
        public IActionResult Delete(int IdProducto)
        {
            var P = _context.tblProductos.FirstOrDefault(p => p.Id == IdProducto);
            if (P == null) return NotFound();
            else
            {
                return View(P);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Producto P)
        {
            _context.Remove(P);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
