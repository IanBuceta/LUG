using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_PreParcial
{
    class PersonaVista
    {
        public List<PersonaVista> LPV { get; set; }
        public PersonaVista(string DNI, string Nombre, string Apellido)
        {
            this.DNI = DNI;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            LPV = new List<PersonaVista>();
        }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NroCompras { get; set; }
        public decimal TotalGastado { get; set; }
        public decimal MayorCompra { get; set; }
    }
}
