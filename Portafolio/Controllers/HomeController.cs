using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            var proyectos = obtenerproyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> obtenerproyectos()
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


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
