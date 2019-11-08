using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// En la entities estan solo las clases, nada mas. Las reglas de negocios se manejan en BLL
    /// </summary>
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
