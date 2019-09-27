using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_modo_desconectado
{
    public class Telefono
    {
        public string Numero { get; set; }
        public Telefono(string Numero)
        {
            this.Numero = Numero;
        }
        public object[] RetornaDatosArray()
        {
            return new object[] { this.Numero };
        }
    }
}
