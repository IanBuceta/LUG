using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// La DAL no conoce a nadie, ya que toca la base de datos nomas. Las demas se comunican con este.
/// </summary>

namespace DAL
{
    public class ServicioDAL
    {
        DataSet Ds;
        //DataTable Dt;
        SqlDataAdapter Da;
        SqlCommandBuilder Cb;
        const string StringDeConexion = @"Data Source=localhost;Initial Catalog=LUG;Integrated Security=True";

        public ServicioDAL()
        {
            Ds = new DataSet();
            Da = new SqlDataAdapter("Select * from Persona", StringDeConexion);
            Cb = new SqlCommandBuilder(Da);

            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.InsertCommand = Cb.GetInsertCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();

            Da.Fill(Ds, "Persona");
            Ds.Tables[0].PrimaryKey = new DataColumn[] { Ds.Tables[0].Columns[0] };
        }

        public DataTable RetornaDataTableVacio(string NombreDataTable)
        {
            Da.SelectCommand.CommandText = $"Select * from {NombreDataTable}";
            DataTable Dt = new DataTable();
            return Da.FillSchema(Dt, SchemaType.Mapped);
        }
        public void BajaBd(DataTable Dt)
        {
            Ds.Tables["Persona"].Rows.Find(Dt.Rows[0]).Delete();
            Guardar(Dt);
        }
        public void Guardar(DataTable Dt)
        {
            Da.Update(Dt);
        }
    }
}
