using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.clases
{
   internal class Operacion
   {
      public int CalcularEdad(DateTime fechaNacimiento)
      {
         int edad = DateTime.Now.Year - fechaNacimiento.Year;
         if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
         {
            edad--;
         }
         return edad;
      }

      public string VerificarMayorEdad(DateTime fechaNacimiento)
      {
         int edad = CalcularEdad(fechaNacimiento);
         return edad >= 18 ? "Mayor de edad" : "Menor de edad";
      }
   }
}