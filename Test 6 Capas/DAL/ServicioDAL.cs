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

        public ServicioDAL()
        {
            Ds = new DataSet("test");
            Da = new SqlDataAdapter("Select * from Persona", "");
        }

        public DataTable RetornaDataTableVacio(string NombreDataTable)
        {
            Da.SelectCommand.CommandText = $"Select * from {NombreDataTable}";
            DataTable Dt = new DataTable();
            return Da.FillSchema(Dt, SchemaType.Mapped);
        }
    }
}
