using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace ABM_modo_desconectado
{
    /// <summary>
    ///     
    /// </summary>
    public class Gestor
    {
        private DataSet Ds;
        private DataTable Dt;
        private DataTable Dtt;

        public Gestor()
        {
            Ds = new DataSet();
            if (File.Exists("Datos.xml"))
            {
                Ds.ReadXml("Datos.xml");
                Dt = Ds.Tables[0];
                Dtt = Ds.Tables[1];
            }
            else
            {
                Dt = new DataTable();
                Dtt = new DataTable();

                DataColumn[] DcArray = { new DataColumn("Legajo", typeof(int)), new DataColumn("Nombre", typeof(string)), new DataColumn("Apellido", typeof(string)) };
                DataColumn[] DctArray = { new DataColumn("Número", typeof(string)), new DataColumn("Legajo", typeof(int))};

                Dt.Columns.AddRange(DcArray);
                Dt.PrimaryKey = new DataColumn[] { Dt.Columns[0] };

                
                Dtt.Columns.AddRange(DctArray);
                Dtt.PrimaryKey = new DataColumn[] { Dtt.Columns[0] };

                Ds.Tables.AddRange(new DataTable[] { Dt, Dtt });

                DataRelation Dr1 = new DataRelation("AluTel", Ds.Tables[0].Columns[0], Ds.Tables[1].Columns[1]);
                Ds.Relations.Add(Dr1);

                Ds.WriteXml("Datos.xml", XmlWriteMode.WriteSchema);
            }            
        }

        public void AgregarAlumno(Alumno A)
        {
            DataRow Dr = Ds.Tables[0].NewRow();
            Dr.ItemArray = A.RetornaDatosArray();
            Ds.Tables[0].Rows.Add(Dr);
            Guardar();
        }

        public void BorrarAlumno(Alumno A)
        {
            Dt.Rows.Find(A.Legajo).Delete(); //Lo marca para ser borrado
            //Dt.Rows.Remove(Dt.Rows.Find(A.Legajo)); //Lo borra de una (No recomendado)
            Guardar();
        }
        public void ModificarAlumno(Alumno A)
        {
            Dt.Rows.Find(A.Legajo).ItemArray = new object[] { A.Legajo, A.Nombre, A.Apellido };
            Guardar();
        }

        public void AgregarTelefono(Telefono T, Alumno A)
        {
            DataRow Dr = Ds.Tables[1].NewRow();
            // Se crea un array de objetos que tiene el numero de telefono y el legajo del alumno para la relacion, igual el devolver los telefonos no se muestra el dueño (aunque se podría)
            Dr.ItemArray = new object[] { T.Numero, A.Legajo }; 
            Ds.Tables[1].Rows.Add(Dr);
            Guardar();
        }

        public void BorrarTelefono(Telefono T)
        {

            //DataRow[] DataRows = Ds.Tables[0].Rows.Find(A.Legajo).GetChildRows("AluTel");
            //foreach (DataRow row in DataRows)
            //{
            //    if (row.ItemArray[0].ToString() == T.Numero)
            //    {
            //        row.Delete();
            //    }                
            //}
            Dtt.Rows.Find(T.Numero).Delete(); //Lo marca para ser borrado
            Guardar();
        }
        public void ModificarTelefono(Telefono T, Alumno A)
        {
            //DataRow[] DataRows = Ds.Tables[0].Rows.Find(A.Legajo).GetChildRows("AluTel");
            //foreach (DataRow row in DataRows)
            //{
            //    if (row.ItemArray[0].ToString() == NumeroViejo)
            //    {
            //        row.ItemArray = new object[] { T.Numero, A.Legajo };
            //    }
            //}
            Dtt.Rows.Find(A.Legajo).ItemArray = new object[] { T.Numero, A.Legajo };
            Guardar();
        }
        private void Guardar()
        {
            Ds.WriteXml("Datos.xml", XmlWriteMode.WriteSchema);
        }
        public List<Telefono> RetornaTelefonos(Alumno A)
        {
            DataRow[] DataRows = Ds.Tables[0].Rows.Find(A.Legajo).GetChildRows("AluTel");
            List<Telefono> T = new List<Telefono>();
            foreach (DataRow row in DataRows)
            {
                T.Add(new Telefono(row.ItemArray[0].ToString()));
            }
            return T;
        }
        public List<Alumno> ReturnAlumnos()
        {
            List<Alumno> Alumnos = new List<Alumno>();

            foreach (DataRow row in Ds.Tables[0].Rows)
            {
                Alumnos.Add(new Alumno(int.Parse((row.ItemArray[0]).ToString()), row.ItemArray[1].ToString(), row.ItemArray[2].ToString()));
            }

            return Alumnos;
        }
        
    }
}
