namespace WebApp.Models
{
    public class Categoria // Basicos, Gama Media , Gama Alta
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Descripcion { get; set; }


        //Prop Navegacion
        public List<Producto>? Productos { get; set; }

    }
}
