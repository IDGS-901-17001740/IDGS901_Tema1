using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class PulquesServices
    {
        public List<Pulques> ObtenerPulque()
        {
            var pulques1 = new Pulques()
            {
                Producto = "Pulque1",
                Descripcion = "Frutos rojos",
                litros = 10,
                Produccion = new DateTime(2023, 11, 10)

            };
            var pulques2 = new Pulques()
            {
                Producto = "Pulque2",
                Descripcion = "Mazapán",
                litros = 20,
                Produccion = new DateTime(2023, 11, 10)

            };
            return new List<Pulques> { pulques1, pulques2 };
        }
    }
}