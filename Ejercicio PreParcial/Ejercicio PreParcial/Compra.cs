using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_PreParcial
{
    public class Compra
    {        
        public Compra(int Id, decimal Importe)
        {
            this.Id = Id;
            this.Importe = Importe;
        }
        public int Id { get; set; }
        public decimal Importe { get; set; }
    }
}
