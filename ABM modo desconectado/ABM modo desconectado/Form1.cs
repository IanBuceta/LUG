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

namespace ABM_modo_desconectado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Gestor Gs = new Gestor();
        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        public void Mostrar()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Gs.ReturnAlumnos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public string Input(string mensaje, string DefaultValue)
        {
            return Interaction.InputBox(mensaje + ":", "", DefaultValue);
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int Legajo = int.Parse(Input("Legajo", ""));
                string Nombre = Input("Nombre","");
                string Apellido = Input("Apellido","");

                Gs.AgregarAlumno(new Alumno(Legajo,Nombre,Apellido));
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Alumno AlumnoSeleccionado()
        {
            try
            {
                return dataGridView1.SelectedRows[0].DataBoundItem as Alumno;
            }
            catch (Exception ex)
            {
                return null;
            }
                
        }
        private Telefono TelefonoSeleccionado()
        {
            try
            {
                return dataGridView2.SelectedRows[0].DataBoundItem as Telefono;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Gs.BorrarAlumno(AlumnoSeleccionado());
                Mostrar();
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
                AlumnoSeleccionado().Nombre = Input("Nuevo Nombre", AlumnoSeleccionado().Nombre);
                AlumnoSeleccionado().Apellido = Input("Nuevo Apellido:", AlumnoSeleccionado().Apellido);
                Gs.ModificarAlumno(AlumnoSeleccionado());
                Mostrar();
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
                string Numero = Input("Número", "");

                Gs.AgregarTelefono(new Telefono(Numero), AlumnoSeleccionado());
                Mostrar();
                DataGridView1_RowEnter(null, null);
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
                Gs.BorrarTelefono(TelefonoSeleccionado());
                Mostrar();
                DataGridView1_RowEnter(null, null);
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
                TelefonoSeleccionado().Numero = Input("Nuevo Numero", TelefonoSeleccionado().Numero);
                Gs.ModificarTelefono(TelefonoSeleccionado(), AlumnoSeleccionado());
                Mostrar();
                DataGridView1_RowEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (AlumnoSeleccionado() != null)
                {
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = Gs.RetornaTelefonos(AlumnoSeleccionado());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
