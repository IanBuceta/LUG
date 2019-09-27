using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EPersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public EPersona()
        {
                           
        }
        public EPersona(int Id, string Nombre, string Apellido)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }
    }
}
