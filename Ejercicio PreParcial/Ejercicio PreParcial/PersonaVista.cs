using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_PreParcial
{
    class PersonaVista
    {
        List<Compra> Compras;

        public PersonaVista(string DNI, string Nombre, string Apellido, List<Compra> Compras)
        {
            this.DNI = DNI;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Compras = Compras;            
        }

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NroCompras
        {
            get
            {
                return Compras.Count;
            }
        }
        public decimal TotalGastado
        {
            get
            {
                return Compras.Sum(x => x.Importe);
            }
        }
        public decimal MayorCompra
        {
            get
            {
                return Compras.Max(x => x.Importe);
            }
        }
                
        
    }
}
