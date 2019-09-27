using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ServicioDAL
    {
        DataSet Ds;
        //DataTable Dt;
        SqlDataAdapter Da;
        SqlCommandBuilder Cb;

        public ServicioDAL()
        {
            Ds = new DataSet("test");
            Da = new SqlDataAdapter("Select * from Persona", "");
            Cb = new SqlCommandBuilder(Da);
            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.InsertCommand = Cb.GetInsertCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();
        }

        public DataTable RetornaDataTableVacio(string NombreDataTable)
        {
            Da.SelectCommand.CommandText = $"Select * from {NombreDataTable}";
            DataTable Dt = new DataTable();
            return Da.FillSchema(Dt, SchemaType.Mapped);
        }
        public void Guardar(DataTable Dt)
        {
            Da.Update(Dt);
        }
    }
}
