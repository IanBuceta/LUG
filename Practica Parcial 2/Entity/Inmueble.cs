using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Inmueble
    {
        public Inmueble(int Id, string Direccion, decimal ValorDeVenta, DateTime FechaDePublicacion, DateTime FechaDeVenta)
        {
            this.Id = Id;
            this.Direccion = Direccion;
            this.ValorDeVenta = ValorDeVenta;
            this.FechaDePublicacion = FechaDePublicacion;
            this.FechaDeVenta = FechaDeVenta;
        }
        public int Id { get; set; }
        public string Direccion { get; set; }
        public decimal ValorDeVenta { get; set; }
        public DateTime FechaDePublicacion { get; set; }
        public DateTime FechaDeVenta { get; set; }
    }
}
