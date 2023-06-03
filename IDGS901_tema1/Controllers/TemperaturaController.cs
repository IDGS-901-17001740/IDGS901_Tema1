using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TemperaturaController : Controller
    {
        // GET: Temperatura
        public ActionResult obtenerCampos()
        {
            return View();
        }
        
        public ActionResult Calcular(Temperatura temp)
        {
            temp.Resultado();
            return View(temp);
        }
    }
}