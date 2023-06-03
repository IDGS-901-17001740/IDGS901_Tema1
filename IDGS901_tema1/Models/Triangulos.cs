using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Xml;

namespace IDGS901_tema1.Models
{
    public class Triangulos
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }
        public double ladoAB { get; set; }
        public double ladoBC { get; set; }
        public double ladoCA { get; set; }
        public String tipo { get; set; }
        public double area { get; set; }
        public String msg { get; set; }

        public double Distancia(double x1, double y1, double x2, double y2)
        {
            //Distancia euclidiana
            //Se calcula la diferencia en entre las coordendas
            double deltaX = x2 - x1; //distancia horizontal entre los puntos
            double deltaY = y2 - y1; //distancia vertical entre los puntos
            //Se usa el teorema de pitagoras para calcular la distancia euclidiana entre los dos puntos.
            //calcula la raíz cuadrada de la suma de los cuadrados
            double distancia = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distancia;
        }

        public bool EsTriangulo(double ladoAB, double ladoBC, double ladoCA)
        {
            return (ladoAB < ladoBC + ladoCA) && (ladoBC < ladoCA + ladoAB) && (ladoCA < ladoAB + ladoBC);
        }

        public String TipoTriangulo(double ladoAB, double ladoBC, double ladoCA)
        {
            if (ladoAB == ladoBC && ladoBC == ladoCA)
            {
                return "Equilátero";
            }
            else if (ladoAB == ladoBC || ladoBC == ladoCA || ladoCA == ladoAB)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }

        public double CalcularArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2);
            return area;
        }
        public void Calcular()
        {
            this.ladoAB = Distancia(this.x1, this.y1,this.x2, this.y2);
            this.ladoBC = Distancia(this.x2, this.y2, this.x3, this.y3);
            this.ladoCA = Distancia(this.x3, this.y3, this.x1, this.y1);

            if(EsTriangulo(this.ladoAB,this.ladoBC, this.ladoCA))
            {
                this.tipo = TipoTriangulo(this.ladoAB, this.ladoBC, this.ladoCA);
                this.area = CalcularArea(this.x1, this.y1, this.x2, this.y2, this.x3, this.y3);
                this.msg = this.area.ToString();
            }
            else
            {
                this.tipo = "Los puntos no generan un triangulo";
                if(this.area == 0)
                {
                    this.msg = "No fue posible calcular el área";
                }
            }
        }





    }
}