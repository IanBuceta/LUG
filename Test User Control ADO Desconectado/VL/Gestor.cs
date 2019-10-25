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
            Da = new SqlDataAdapter("Select * from Persona", "Data Source=342-22-84561\SQL_UAI;Initial Catalog=LUG;Integrated Security=True");
            Cb = new SqlCommandBuilder(Da);

            Da.InsertCommand = Cb.GetInsertCommand();
            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();

            FillTable(0, 10);
            
        }

        private void FillTable(int start, int max)
        {
            Da.Fill(Ds, start, max, "Persona");
        }
    }
}
