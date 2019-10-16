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
    public class OPersona : IABMC<EPersona>
    {
        ServicioDAL sDAL;
        public OPersona()
        {
            sDAL = new ServicioDAL();
        }         

        public void Alta(EPersona pObject)
        {
            DataTable Dt = sDAL.RetornaDataTableVacio("Persona");
            object[] O = new object[] { pObject.Id, pObject.Nombre, pObject.Apellido }; // TODO Agregar interfaz
            Dt.Rows.Add(O);
            sDAL.Guardar(Dt);
        }

        public void Baja(EPersona pObject)
        {
            DataTable Dt = sDAL.RetornaDataTableVacio("Persona");
            DataRow Dr = Dt.NewRow();
            object[] O = new object[] { pObject.Id, pObject.Nombre, pObject.Apellido };
            Dt.Rows.Add(Dt);
            sDAL.BajaBd(Dt);
        }

        public void Consulta(EPersona pObject)
        {
            throw new NotImplementedException();
        }

        public void ConsultaTodos()
        {
            throw new NotImplementedException();
        }

        public void Modificacion(EPersona pObject)
        {
            throw new NotImplementedException();
        }
    }
}
