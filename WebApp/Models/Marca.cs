namespace WebApp.Models
{
    public class Marca //Sony - Intel - Amd - Msi - Asus
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Descripcion { get; set; }


        //Prop Navegacion
        public List<Producto>? Productos { get; set; }
    }
}
