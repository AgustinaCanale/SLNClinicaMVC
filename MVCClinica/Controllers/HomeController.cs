using Microsoft.AspNetCore.Mvc;
using System;

namespace MVCClinica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido al sistema de Medicos";
            ViewBag.Fecha = DateTime.Now;
            return View();
        }
    }
}
