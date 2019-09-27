using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using Interfaces;

namespace ORM
{
    public class OPersona : IABMC
    {
        ServicioDAL SDAL;
        public OPersona()
        {
            SDAL = new ServicioDAL();
        } 
        public void Alta()
        {
            SDAL.RetornaDataTableVacio("Persona");
        }

        public void Baja()
        {
            throw new NotImplementedException();
        }

        public void Consulta()
        {
            throw new NotImplementedException();
        }

        public void Modificacion()
        {
            throw new NotImplementedException();
        }
    }
}
