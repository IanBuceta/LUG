using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VL
{
    public class Gestor
    {
        SqlDataAdapter Da;
        SqlCommandBuilder Cb;
        DataSet Ds;

        public Gestor()
        {
            Ds = new DataSet();
            Da = new SqlDataAdapter("Select * from Persona", @"Data Source=342-22-84561\SQL_UAI;Initial Catalog=LUG;Integrated Security=True");
            Cb = new SqlCommandBuilder(Da);

            Da.InsertCommand = Cb.GetInsertCommand();
            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();
            
            FillTable(0, 10);
        }
        public void Agregar(Persona Per)
        {
            DataRow Dr = Ds.Tables[0].NewRow();
            Dr.ItemArray = new object[] { Per.Id, Per.Nombre, Per.Apellido };
            Ds.Tables[0].Rows.Add(Dr);
        }
        public void Borrar(Persona Per)
        {
            Ds.Tables[0].Rows.Find(Per.Id).Delete();
        }
        public void FillTable(int start, int max)
        {
            Ds.Tables.Clear();
            Da.Fill(Ds, start, max, "Persona");
            Ds.Tables[0].PrimaryKey = new DataColumn[] { Ds.Tables[0].Columns[0] };
        }
        public List<Persona> VerPersonas()
        {
            DataView Dv = new DataView(Ds.Tables[0], "", "", DataViewRowState.CurrentRows);
            List<Persona> Personas = new List<Persona>();

            foreach (DataRowView DrV in Dv)
            {
                Persona P = new Persona(DrV.Row.Field<int>(0), DrV.Row.Field<string>(1), DrV.Row.Field<string>(2));
                Personas.Add(P);                
            }
            return Personas;
        }

        public void Guardar()
        {
            Da.Update(Ds.Tables[0]);
            Ds.AcceptChanges();            
        }
    }
}
