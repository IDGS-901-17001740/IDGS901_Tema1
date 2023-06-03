using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Temperatura
    {
        public double TemperaturaBase { get; set; }
        public String Eleccion { get; set; }

        public double res { get; set; }

        public void Resultado()
        {
            var op = this.Eleccion;

            if(Eleccion == "1") {
                CalcularFahrenheit();
            } else
            {
                calcularCelsius();
            }
        }

        public void calcularCelsius()
        {
            this.res = (this.TemperaturaBase - 32) * 5 / 9;
        }

        public void CalcularFahrenheit()
        {
            this.res = (this.TemperaturaBase * 9 / 5) + 32;
        }
    }
}