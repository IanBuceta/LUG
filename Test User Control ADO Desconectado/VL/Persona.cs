using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VL
{
    public class Persona
    {
        public int Id { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(int Id, string Nombre, string Apellido)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }
    }
}
