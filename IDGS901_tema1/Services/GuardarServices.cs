using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class GuardarServices
    {
        // Método para guardar archivo
        public void GuardarArchivo(Maestros maestros)
        {
            var mat = maestros.matricula;
            var nombre = maestros.nombre;
            var apaterno = maestros.aPaterno;
            var amaterno = maestros.aMaterno;
            var email = maestros.email;
            
            var datos = mat + "," + nombre + "," + apaterno + "," + amaterno + "," + email + ","+Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Datos.txt");
            //File.WriteAllText(archivo, datos);

            File.AppendAllText(archivo, datos);
        }
    }
}