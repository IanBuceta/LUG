using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using Interfaces;
using System.Data;

/// <summary>
/// ORM coonoce a: DAL, Entities e interfaces.
/// </summary>
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
            Dt.PrimaryKey = new DataColumn[] { Dt.Columns[0] };
            Dt.Rows.Find(pObject.Id).Delete();
            sDAL.Guardar(Dt);
        }

        public void Consulta(EPersona pObject)
        {
            throw new NotImplementedException();
        }

        public List<EPersona> ConsultaTodos()
        {
            DataTable Dt = sDAL.RetornaDataTableVacio("Persona");
            List<EPersona> Personas = new List<EPersona>();
            foreach (DataRow dataRow in Dt.Rows)
            {
                Personas.Add(new EPersona(dataRow.Field<int>(0), dataRow.Field<string>(1), dataRow.Field<string>(2)));
            }
            return Personas;
        }

        public void Modificacion(EPersona pObject)
        {
            DataTable Dt = sDAL.RetornaDataTableVacio("Persona");
            Dt.PrimaryKey = new DataColumn[] { Dt.Columns[0] };
            DataRow Dr = Dt.Rows.Find(pObject.Id);
            Dr["Per_Id"] = pObject.Id;
            Dr["Per_Nombre"] = pObject.Nombre;
            Dr["Per_Apellido"] = pObject.Apellido;
            sDAL.Guardar(Dt);

        }
    }
}
