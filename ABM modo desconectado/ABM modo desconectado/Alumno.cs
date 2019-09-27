using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_modo_desconectado
{
    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public object[] RetornaDatosArray()
        {
            return new object[] { this.Legajo, this.Nombre, this.Apellido };
        }

        public Alumno(int Legajo, string Nombre, string Apellido)
        {
            this.Legajo = Legajo;
            this.Nombre = Nombre;
            this.Apellido = Apellido;            
        }   
    }
}
