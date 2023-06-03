using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Calcular(Triangulos triangulos)
        {
            triangulos.Calcular();
            return View(triangulos);
        }
    }
}