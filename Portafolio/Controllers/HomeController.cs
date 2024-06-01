using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Collections.Generic;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;

        public HomeController(ILogger<HomeController> logger,
            IRepositorioProyectos repositorioProyectos

            )
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
           
        }

        public IActionResult Index()
        {

            _logger.LogTrace("este es un mensaje de Trace");
            _logger.LogDebug("este es un mensaje de Debug");
            _logger.LogWarning("este es un mensaje de Warning");
            _logger.LogInformation("este es un mensaje de Information");
            _logger.LogError("este es un mensaje de Error");
            _logger.LogCritical("este es un mensaje de critical");
            var proyectos = repositorioProyectos.obtenerproyectos().Take(3).ToList();
            

            var modelo = new HomeIndexViewModel() { 
                Proyectos = proyectos
            };
            return View(modelo);
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
