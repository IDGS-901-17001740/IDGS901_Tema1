using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OperasBas(string n1, string n2, string grupo)
        {
            int res = 0;
           
            if (grupo == "suma")
            {
                res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            }

            if (grupo == "resta")
            {
                res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
            }

            if (grupo == "multi")
            {
                res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
            }

            if (grupo == "div")
            {
                res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
            }

            ViewBag.Res = res;

            return View();
        }

        public ActionResult MuestraPulques()
        {
            var pulquesService1 = new PulquesServices();
            var model = pulquesService1.ObtenerPulque();

            return View(model);
        }

        public ActionResult Calculos(OperasBas op, string grupo)
        {
            op.decision(grupo);

            return View(op);
            
            
        }
    }
}