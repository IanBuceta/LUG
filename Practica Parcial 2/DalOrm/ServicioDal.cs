using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using Interfaces;

namespace DalOrm
{
    public class ServicioDal : IABMCEmpleado<Empleado>, IAMBCInmueble<Inmueble>, IGuardar
    {
        DataSet Ds;

        SqlDataAdapter DaEmpleado;
        SqlCommandBuilder CbEmpleado;
        DataColumn PkEmpleado;

        SqlDataAdapter DaInmueble;
        SqlCommandBuilder CbInmueble;
        DataColumn PkInmueble;
        DataColumn FkInmueble;

        DataRelation Dr;

        public ServicioDal()
        {
            Ds = new DataSet();
            GenerarTablaEmpleado();
            GenerarTablaInmueble();
            GenerarDataRelation();
        }

        private void GenerarTablaEmpleado()
        {
            DaEmpleado = new SqlDataAdapter("Select * from Empleado", "Data Source = localhost; Initial Catalog = LUG; Integrated Security = True");
            CbEmpleado = new SqlCommandBuilder(DaEmpleado);

            DaEmpleado.InsertCommand = CbEmpleado.GetInsertCommand();
            DaEmpleado.UpdateCommand = CbEmpleado.GetUpdateCommand();
            DaEmpleado.DeleteCommand = CbEmpleado.GetDeleteCommand();

            DaEmpleado.Fill(Ds, "Empleado");

            PkEmpleado = Ds.Tables["Empleado"].Columns["Empleado_Id"];
            Ds.Tables["Empleado"].PrimaryKey = new DataColumn[] { PkEmpleado };
        }

        private void GenerarTablaInmueble()
        {
            DaInmueble = new SqlDataAdapter("Select * from Inmueble", "Data Source = localhost; Initial Catalog = LUG; Integrated Security = True");
            CbInmueble = new SqlCommandBuilder(DaInmueble);

            DaInmueble.InsertCommand = CbInmueble.GetInsertCommand();
            DaInmueble.UpdateCommand = CbInmueble.GetUpdateCommand();
            DaInmueble.DeleteCommand = CbInmueble.GetDeleteCommand();

            DaInmueble.Fill(Ds, "Inmueble");

            PkInmueble = Ds.Tables["Inmueble"].Columns["Inmueble_Id"];
            FkInmueble = Ds.Tables["Inmueble"].Columns["Inmueble_IdEmpleado"];
            Ds.Tables["Inmueble"].PrimaryKey = new DataColumn[] { PkInmueble };
        }

        private void GenerarDataRelation()
        {
            Dr = new DataRelation("EmpInmu", PkEmpleado, FkInmueble);
            Ds.Relations.Add(Dr);
        }


        

        public void AltaEmpleado(Empleado empleado)
        {
            DataRow dRow = Ds.Tables["Empleado"].NewRow();
            dRow.ItemArray = new object[] { empleado.Id, empleado.Nombre, empleado.TotalRecaudado };
            Ds.Tables["Empleado"].Rows.Add(dRow);
        }

        public void BajaEmpleado(Empleado empleado)
        {
            Ds.Tables["Empleado"].Rows.Find(empleado.Id).Delete();
        }

        public void ModificacionEmpleado(Empleado empleado, string idOriginal)
        {
            DataRow dRow = Ds.Tables["Empleado"].Rows.Find(idOriginal);
            dRow.ItemArray = new object[] { empleado.Id, empleado.Nombre, empleado.TotalRecaudado };
        }        

        public void AltaInmueble(Inmueble inmueble, string IdEmpleado)
        {
            DataRow dRow = Ds.Tables["Inmueble"].NewRow();
            dRow.ItemArray = new object[] { inmueble.Id, IdEmpleado, inmueble.Direccion, inmueble.ValorDeVenta, inmueble.FechaDePublicacion, inmueble.FechaDeVenta};
            Ds.Tables["Inmueble"].Rows.Add(dRow);
        }

        public void BajaInmueble(Inmueble inmueble)
        {
            Ds.Tables["Inmueble"].Rows.Find(inmueble.Id).Delete();
        }

        public void ModificacionInmueble(Inmueble inmueble, string idOriginal)
        {
            DataRow dRow = Ds.Tables["Inmueble"].Rows.Find(idOriginal);
            dRow.ItemArray = new object[] { inmueble.Id, inmueble.Direccion, inmueble.ValorDeVenta, inmueble.FechaDePublicacion, inmueble.FechaDeVenta };
        }
        public List<Empleado> ConsultaTodos()
        {
            List<Empleado> empleados = new List<Empleado>();
            DataView dataTableEmp = new DataView(Ds.Tables["Empleado"],"","", DataViewRowState.CurrentRows);           

            foreach (DataRowView dataRow in dataTableEmp)
            {
                Empleado empleado = new Empleado(dataRow.Row.Field<string>(0), dataRow.Row.Field<string>(1));
                empleados.Add(empleado);
                foreach (var inmueble in dataRow.Row.GetChildRows("EmpInmu"))
                {
                    empleado.AgregarInmueble(new Inmueble(inmueble.Field<int>(0), inmueble.Field<string>(2), inmueble.Field<decimal>(3), inmueble.Field<DateTime>(4), inmueble.Field<DateTime>(5)));
                }
            }

            return empleados;
        }
        public void Guardar()
        {
            DaEmpleado.Update(Ds.Tables["Empleado"]);
            DaInmueble.Update(Ds.Tables["Inmueble"]);
        }
    }
}
