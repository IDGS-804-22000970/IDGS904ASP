using IDGS904ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contacto()
        {
            ViewBag.Nombre = "Tadeo Morales";
            ViewBag.Titulo = "MISEC";
            ViewData["Materia"] = "DWI";
            return View();
        }

        public ActionResult Empleado()
        {
            var persona = new Persona()
            {
                Nombre="Claudia",
                Edad=20,
                Empleado=true,
                Nacimiento=new DateTime(2000,1,1)
            };
            ViewBag.Propiedad = persona;
            return View();
        }
    }
}