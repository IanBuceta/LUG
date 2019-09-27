using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_DataAdapter
{
    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public bool Activo { get; set; }

        private List<Telefono> Telefonos { get; set; }

        public Alumno(int Legajo, string Nombre, string Apellido, DateTime FechaDeIngreso, bool Activo)
        {
            this.Legajo = Legajo;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.FechaDeIngreso = FechaDeIngreso;
            this.Activo = Activo;
            Telefonos = new List<Telefono>();
        }
        public void AgregarTelefono(Telefono T)
        {
            Telefonos.Add(T);
        }
        public void RemoverTelefono(Telefono T)
        {
            //Telefonos.Remove(T);
            Telefonos.Remove(Telefonos.Find(x => x.Id == T.Id));
        }
        public Telefono[] RetornarTelefonos()
        {
            return Telefonos.ToArray();
        }        
    }
}
