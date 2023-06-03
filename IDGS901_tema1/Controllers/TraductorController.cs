using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
       public ActionResult Registrar()
        {
            var archivo = new GuardarPalabras();
            ViewBag.Palabras = archivo.LeerPalabras();
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Traductor traductor)
        {
            var op = new GuardarPalabras();
            op.GuardarArchivo(traductor);
            Registrar();
            return View();
        }

        public ActionResult obtenerCampos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuscarPalabras(string palabra, string eleccion)
        {
            var archivo = Server.MapPath("~/App_Data/Traductor.txt");

            String resultados = GuardarPalabras.BuscarPalabras(archivo, palabra, eleccion);

            ViewBag.Resultados = resultados;
            return View();
        }

    }
}