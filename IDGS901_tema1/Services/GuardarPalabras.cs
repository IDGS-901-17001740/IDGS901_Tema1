using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class GuardarPalabras
    {
        // Método para guardar archivo
        public void GuardarArchivo(Traductor traductor)
        {
            var esp = traductor.espaniol.ToLower();
            var ingl = traductor.ingles.ToLower();

            var datos = esp + "," + ingl + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Traductor.txt");
            //File.WriteAllText(archivo, datos);

            File.AppendAllText(archivo, datos);
        }

        // Método para Leer el archivo
        public Array LeerPalabras()
        {
            Array palabrasData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Traductor.txt");
            if (File.Exists(archivo))
            {
                // Obtener el contenido del archivo
                palabrasData = File.ReadAllLines(archivo);
            }
            return palabrasData;
        }

        // Método para buscar palabras
        public static String BuscarPalabras(string rutaArchivo, string palabra, string eleccion)
        {
            String res = "";

            // Lee todas las líneas del archivo
            string[] lineas = File.ReadAllLines(rutaArchivo);


            foreach (string linea in lineas)
            {
                string[] palabras = linea.Split(',');
                //Console.WriteLine(palabras);
                res = palabras.ToString();

                if (palabras[0].Trim().Equals(palabra, StringComparison.OrdinalIgnoreCase)
                    || palabras[1].Trim().Equals(palabra, StringComparison.OrdinalIgnoreCase))
                {

                    if (eleccion.Equals("1", StringComparison.OrdinalIgnoreCase))
                    {
                        res = palabras[0].Trim().ToString();
                    }
                    else
                    {
                        res = palabras[1].Trim().ToString();
                    }
                }
                else
                {
                    res = "La palabra no existe";

                }

            }
            return res.ToString();

        }

    }
}