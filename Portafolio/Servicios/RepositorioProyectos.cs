using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos
    {
        public List<Proyecto> obtenerproyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-Comerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL="/Images/Amazon.jpg"
            },
                new Proyecto
            {
                Titulo = "New York Times",
                Descripcion = "Pagina de noticias en react",
                Link = "https://nytimes.com",
                ImagenURL="/Images/nytimes.jpg"
            },
                new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL="/Images/Reddit.png"
            },
                new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Tienda en linea para comprar videojuegos",
                Link = "https://store.steampowered.com",
                ImagenURL="/Images/Steam.jpg"
            }
            };
        }
    }
}
