using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Test_DataAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet Ds;

        SqlDataAdapter DaAlu;        
        SqlCommandBuilder CbAlu;

        SqlDataAdapter DaTel;
        SqlCommandBuilder CbTel;
        DataRelation Dr;

        MapperAlumno Ma;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewAlumno.MultiSelect = false;
            dataGridViewTelefono.MultiSelect = false;

            Ds = new DataSet();

            DaAlu = new SqlDataAdapter("SELECT * FROM Alumno", @"Data Source=342-29-84569\SQL_UAI;Initial Catalog=test;Integrated Security=True");
            CbAlu = new SqlCommandBuilder(DaAlu);

            DaAlu.InsertCommand = CbAlu.GetInsertCommand();
            DaAlu.UpdateCommand = CbAlu.GetUpdateCommand();
            DaAlu.DeleteCommand = CbAlu.GetDeleteCommand();
            DaAlu.Fill(Ds, "Alumno");

            DaTel = new SqlDataAdapter("SELECT * FROM Telefono", @"Data Source=342-29-84569\SQL_UAI;Initial Catalog=test;Integrated Security=True");
            CbTel = new SqlCommandBuilder(DaAlu);
            DaTel.InsertCommand = CbTel.GetInsertCommand();
            DaTel.UpdateCommand = CbTel.GetUpdateCommand();
            DaTel.DeleteCommand = CbTel.GetDeleteCommand();
            DaTel.Fill(Ds, "Telefono");

            Dr = new DataRelation("AluTel", Ds.Tables["Alumno"].Columns[0], Ds.Tables["Telefono"].Columns[0]);
            Ds.Relations.Add(Dr);

            Ma = new MapperAlumno(Ds);

            DataColumn[] PrimaryKeyAlumno = new DataColumn[] { Ds.Tables["Alumno"].Columns[0] };
            Ds.Tables["Alumno"].PrimaryKey = PrimaryKeyAlumno;

            DataColumn[] PrimaryKeyTelefono = new DataColumn[] { Ds.Tables["Telefono"].Columns[1] };
            Ds.Tables["Telefono"].PrimaryKey = PrimaryKeyTelefono;

            Mostrar(dataGridViewAlumno, Ma.RetornaAlumnos);
        }
        private Alumno AlumnoSeleccionado()
        {
            try
            {
                return dataGridViewAlumno.SelectedRows[0].DataBoundItem as Alumno;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Telefono TelefonoSeleccionado()
        {
            try
            {
                return dataGridViewTelefono.SelectedRows[0].DataBoundItem as Telefono;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void Mostrar(DataGridView Dgv, object o)
        {
            Dgv.DataSource = null;
            Dgv.DataSource = o;

            DataView DvA = new DataView(Ds.Tables[0], "","", DataViewRowState.Added);
            dataGridViewAgregar.DataSource = null;
            dataGridViewAgregar.DataSource = DvA;

            DataView DvD = new DataView(Ds.Tables[0], "", "", DataViewRowState.Deleted);
            dataGridViewBorrar.DataSource = null;
            dataGridViewBorrar.DataSource = DvD;

            DataView DvM = new DataView(Ds.Tables[0], "", "", DataViewRowState.ModifiedOriginal);
            dataGridViewModificar.DataSource = null;
            dataGridViewModificar.DataSource = DvM;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int Legajo = int.Parse(Input("Legajo",""));
                string Nombre = Input("Nombre", "");
                string Apellido = Input("Apellido", "");
                DateTime FechaDeIngreso = DateTime.Parse(Input("Fecha de Ingreso", ""));
                bool Activo = bool.Parse(Input("Activo", ""));

                Ma.AgregarAlumno(new Alumno(Legajo, Nombre, Apellido, FechaDeIngreso, Activo));
                Mostrar(dataGridViewAlumno, Ma.RetornaAlumnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private string Input(string Texto, string Default)
        {
            return Interaction.InputBox(Texto + ":","", Default);
        }

        private void dataGridViewAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Mostrar(dataGridViewTelefono, AlumnoSeleccionado().RetornarTelefonos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DaAlu.Update(Ds.Tables["Alumno"]);
                Ds.Tables["Alumno"].AcceptChanges();
                Mostrar(dataGridViewAlumno, Ma.RetornaAlumnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Ma.BorrarAlumnno(AlumnoSeleccionado());
                Mostrar(dataGridViewAlumno, Ma.RetornaAlumnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno A = AlumnoSeleccionado();
                if (A == null) throw new Exception("Seleccione un Alumno.");
                A.Nombre = Input("Ingrese un nuevo nombre:", A.Nombre);
                A.Apellido = Input("Ingrese un nuevo nombre:", A.Apellido);
                A.FechaDeIngreso = DateTime.Parse(Input("Ingrese un nuevo nombre:", A.FechaDeIngreso.ToString()));
                Ma.ModificarAlumno(A);
                Mostrar(dataGridViewAlumno, Ma.RetornaAlumnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = AlumnoSeleccionado().Legajo;
                string Numero = Input("Ingrese numero", "");

                Ma.AgregarTelefono(new Telefono(Id,Numero));
                Mostrar(dataGridViewAlumno, Ma.RetornaAlumnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BorrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Ma.BorrarTelefono(TelefonoSeleccionado());
                Mostrar(dataGridViewTelefono, AlumnoSeleccionado().RetornarTelefonos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void ModificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException("Hay que ver que modificar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
