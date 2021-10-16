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

        public IActionResult Index()
        {
            persona person = new persona();
            person.NombrePersona = "Eduardo";
            person.EdadPersona = 21;
            person.DescripcionPersona = "estudiante";

            ipersona.Save(person);

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
