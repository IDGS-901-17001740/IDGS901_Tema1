using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            //return Content("<h1>IDGS901-DWI</h1>");
            // Dato que permite pasar parametros de acción en acción: 1-> 2
            //TempData["Nombre"] = "Alumno:Ana";

            return View();


        }

        public JsonResult About()
        {
            var pulque = new Pulques()
            {
                Producto = "pulque",
                Descripcion = "Sabor Mango",
                litros = 20,
                Produccion = new DateTime(2023, 13, 5)
            };

            return Json(pulque, JsonRequestBehavior.AllowGet);
        }

        public RedirectResult About1()
        {
            return Redirect("https://google.com.mx");
        }

        // Para redireccionar a un controlador
        public RedirectToRouteResult About2()
        {
            TempData["Nombre"] = "Alumno: Elena";

            return RedirectToAction("Informacion");
        }

        public ActionResult Informacion() 
        {
            ViewBag.Grupo = "IDGS901";
            ViewData["Materia"] = "DWI";
            string nombre = "";
            if(TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }
            ViewBag.Nombre = nombre;

            return View();
        }
    }
}