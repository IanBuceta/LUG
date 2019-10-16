using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using Interfaces;
using System.Data;

namespace ORM
{
    public class OPersona : IABMC
    {
        ServicioDAL sDAL;
        public OPersona()
        {
            sDAL = new ServicioDAL(EPersona pObject);
        } 
        public void Alta()
        {
            DataTable Dt = sDAL.RetornaDataTableVacio("Persona");
            object[] O = new object[] {pObject.id, etc} // TODO Agregar interfaz
            Dt.Rows.Add(O);
            sDAL.Guardar(Dt);
        }

        public void Baja()
        {
            ;
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
