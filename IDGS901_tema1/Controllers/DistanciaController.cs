using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult obtenerCampos()
        {
            return View();
        }

        public ActionResult Calcular(Distancia distancia) {
            distancia.Operacion(); 
            return View(distancia);
        }
    }
}