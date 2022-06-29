using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? DescripcionLarga { get; set; }
        public bool UVRayos { get; set; }
        public bool UVNORayos { get; set; }
        public string? ImagenUrl { get; set; }

        [NotMapped]
        public IFormFile? ImagenFile { get; set; }

        //Foreign Keys
        public int MarcaId { get; set; }
        public Marca? Marca { get; set; }

        public int TipoId { get; set; }
        public Tipo? Tipo { get; set; }

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
        public int SucursalId { get; set; }
        public Sucursal? Sucursal  { get; set; }

    }
}
