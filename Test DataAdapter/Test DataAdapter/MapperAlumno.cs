using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Test_DataAdapter
{
    public class MapperAlumno
    {
        DataSet Ds;
        List<Alumno> Alumnos;
        public MapperAlumno(DataSet Ds)
        {
            this.Ds = Ds;
            Alumnos = new List<Alumno>();
            ActualizaLista();
        }
        private void ActualizaLista()
        {
            Alumnos.Clear();
            DataView DvAux = new DataView(Ds.Tables[0], "", "", DataViewRowState.CurrentRows);
            foreach (DataRowView r in DvAux)
            {
                Alumnos.Add(new Alumno(r.Row.Field<int>(0), r.Row.Field<string>(1), r.Row.Field<string>(2), r.Row.Field<DateTime>(3), r.Row.Field<bool>(4)));
                foreach (DataRow rt in r.Row.GetChildRows("AluTel"))
                {
                    Alumnos.Last().AgregarTelefono(new Telefono(rt.Field<int>(0), rt.Field<string>(1)));
                }
            }
        }
        public List<Alumno> RetornaAlumnos
        {
            get
            {
                return Alumnos;
            }
        }

        public void AgregarAlumno(Alumno A)
        {
            DataRow Dr = Ds.Tables[0].NewRow();
            object[] O = { A.Legajo, A.Nombre, A.Apellido, A.FechaDeIngreso, A.Activo };
            Dr.ItemArray = O;
            Ds.Tables[0].Rows.Add(Dr);
            ActualizaLista();
        }
        public void BorrarAlumnno(Alumno A)
        {
            if (A != null)
            {
                Ds.Tables["Alumno"].Rows.Find(A.Legajo).Delete();
                foreach (Telefono T in A.RetornarTelefonos())
                {
                    BorrarTelefono(T);
                }
                ActualizaLista();
            }
        }       

        public void ModificarAlumno(Alumno A)
        {
            if (A != null)
            {
                object[] O = { A.Legajo, A.Nombre, A.Apellido, A.FechaDeIngreso, A.Activo };
                Ds.Tables["Alumno"].Rows.Find(A.Legajo).ItemArray = O;
                ActualizaLista();
            }
        }

        public void AgregarTelefono(Telefono T)
        {
            DataRow Dr = Ds.Tables[1].NewRow();
            object[] O = { T.Id, T.Numero };
            Dr.ItemArray = O;
            Ds.Tables[1].Rows.Add(Dr);
            ActualizaLista();
        }
        public void BorrarTelefono(Telefono T)
        {
            if (T != null)
            {
                Ds.Tables["Alumno"].Rows.Find(T.Numero).Delete();
                ActualizaLista();
            }
        }
        public void ModificarTelefono(Telefono T)
        {
            if (T != null)
            {
                object[] O = { T.Id, T.Numero };
                Ds.Tables["Telefono"].Rows.Find(T.Numero).ItemArray = O;
                ActualizaLista();
            }          
        }
    }
}
