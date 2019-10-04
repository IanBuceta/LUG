using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_PreParcial
{
    public class Persona
    {
        List<Compra> Compras;
        public Persona(string DNI, string Nombre, string Apellido)
        {
            this.DNI = DNI;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            Compras = new List<Compra>();
        }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public void CargarCompra(Compra C)
        {
            Compras.Add(C);
        }
    }

}
