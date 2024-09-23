using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.clases
{
   internal class Registro
   {
      private List<Persona> personas;

      public Registro()
      {
         personas = new List<Persona>();
      }

      public void AgregarPersona(Persona persona)
      {
         if (personas.Count < 30)
         {
            personas.Add(persona);
         }
         else
         {
            throw new InvalidOperationException("No se pueden agregar más de 30 personas.");
         }
      }

      public List<Persona> ObtenerPersonas()
      {
         return personas;
      }
   }
}