using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioN2.Dominio;
using LaboratorioN2.Models;
using LaboratorioN2.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LaboratorioN2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Ipersona ipersona;

        public HomeController(ILogger<HomeController> logger, Ipersona ipersona)
        {
            this.ipersona = ipersona;
            _logger = logger;
        }

        public IActionResult guardado()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Guardado(persona E)
        {
            if (ModelState.IsValid)
            {
                ipersona.Save(E);
                return View();
            }
            else
            {
                return View("Guardado", E);
            }
        }

        public IActionResult Index()
        {
            //persona person = new persona();
            //person.NombrePersona = "Kevin";
            //person.EdadPersona = 21;
            //person.DescripcionPersona = "estudiante";

            //ipersona.Save(person);

            return View();
        }


        public IActionResult GetDatos()
        {
            //var forJson = ipersona.listardatos();

            //return Json(new { data = forJson });

            var DandoFormatoJson = ipersona.Listardatos();

            return Json(new { data = DandoFormatoJson });
        }

        public IActionResult MostrarTabla()
        {
            return View();
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
