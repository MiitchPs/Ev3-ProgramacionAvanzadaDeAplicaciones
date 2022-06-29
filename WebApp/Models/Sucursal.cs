namespace WebApp.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }


        //Prop Navegacion
        public List<Producto>? Productos { get; set; }


    }
}
