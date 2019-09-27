using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_DataAdapter
{
    public class Telefono
    {
        public int Id { get; private set; }
        public string Numero { get; set; }        

        public Telefono(int Id, string Numero)
        {
            this.Id = Id;
            this.Numero = Numero;
            
        }
    }
}
