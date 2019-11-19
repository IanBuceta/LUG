using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado
    {

        public Empleado(string Id, string Nombre)
        {
            Inmuebles = new List<Inmueble>();
            this.Id = Id;
            this.Nombre = Nombre;
        }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public decimal TotalRecaudado
        {
            get
            {
                return Inmuebles.Sum(x => x.ValorDeVenta);
            }
        }
        public List<Inmueble> Inmuebles { get; }

        public void AgregarInmueble(Inmueble inmueble)
        {
            Inmuebles.Add(inmueble);
        }
    }
}
