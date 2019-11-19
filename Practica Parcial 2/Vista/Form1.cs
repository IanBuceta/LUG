using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using Bll;
using Entity;

namespace Vista
{
    public partial class Form1 : Form
    {
        Gestor gestor;
        public Form1()
        {
            InitializeComponent();
            gestor = new Gestor();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void Mostrar()
        {
            dataGridEmpleados.DataSource = null;
            dataGridEmpleados.DataSource = gestor.ConsultaTodos();
            dataGridInmuebles.DataSource = null;
        }
        private void buttonAltaEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = controlEmpleado1.Controls["textBoxIdEmp"].Text;
                string Nombre = controlEmpleado1.Controls["textBoxNomEmp"].Text;

                if (controlEmpleado1.IdValido() == false) throw new Exception("El Id tiene que poseer el siguiente formato: AAA-123");
                gestor.AltaEmpleado(new Empleado(Id, Nombre));

                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBajaEmp_Click(object sender, EventArgs e)
        {
            try
            {
                gestor.BajaEmpleado(EmpleadoSeleccionado());
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonModEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = controlEmpleado1.Controls["textBoxIdEmp"].Text;
                string Nombre = controlEmpleado1.Controls["textBoxNomEmp"].Text;
                gestor.ModificacionEmpleado(new Empleado(Id, Nombre), EmpleadoSeleccionado().Id);
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataGridEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controlEmpleado1.Controls["textBoxIdEmp"].Text = EmpleadoSeleccionado().Id.ToString();
            controlEmpleado1.Controls["textBoxNomEmp"].Text = EmpleadoSeleccionado().Nombre;
            dataGridInmuebles.DataSource = null;
            dataGridInmuebles.DataSource = EmpleadoSeleccionado().Inmuebles;
            MostrarGrafico();
        }

        private void MostrarGrafico()
        {
            try
            {
                Graphics gr = this.CreateGraphics();
                Random r = new Random(DateTime.Now.Millisecond);
                List<Inmueble> inmuebles = EmpleadoSeleccionado().Inmuebles;
                int offsetX = 0;

                gr.Clear(this.BackColor);
                foreach (var inmueble in inmuebles)
                {
                    SolidBrush sB = new SolidBrush(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
                    float altoMáximo = (float)(inmueble.ValorDeVenta * 100) / (float)inmuebles.Max(x => x.ValorDeVenta);
                    gr.FillRectangle(sB, 400 + offsetX, 180 + 250 - altoMáximo, 20, altoMáximo);
                    gr.DrawString(inmueble.ValorDeVenta.ToString(), new Font("Arial", 12), sB, 403 + offsetX, 430);
                    offsetX += 30;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridInmuebles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIdIn.Text = InmuebleSeleccionado().Id.ToString();
            textBoxDirIn.Text = InmuebleSeleccionado().Direccion;
            textBoxValorIn.Text = InmuebleSeleccionado().ValorDeVenta.ToString();
            textBoxPubIn.Text = InmuebleSeleccionado().FechaDePublicacion.ToString();
            textBoxFVentaIn.Text = InmuebleSeleccionado().FechaDeVenta.ToString();
        }

        private Empleado EmpleadoSeleccionado()
        {
            return dataGridEmpleados.SelectedRows[0].DataBoundItem as Empleado;
        }
        private Inmueble InmuebleSeleccionado()
        {
            return dataGridInmuebles.SelectedRows[0].DataBoundItem as Inmueble;
        }       

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                gestor.Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonAltaIn_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(textBoxIdIn.Text);
                string Direccion = textBoxDirIn.Text;
                decimal ValorDeVenta = decimal.Parse(textBoxValorIn.Text);
                DateTime FechaDePublicacion = DateTime.Parse(textBoxPubIn.Text);
                DateTime FechaDeVenta = DateTime.Parse(textBoxFVentaIn.Text);

                gestor.AltaInmueble(new Inmueble(Id, Direccion, ValorDeVenta, FechaDePublicacion, FechaDeVenta), EmpleadoSeleccionado().Id);
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBajaIn_Click(object sender, EventArgs e)
        {
            try
            {
                gestor.BajaInmueble(InmuebleSeleccionado());
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonModIn_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(textBoxIdIn.Text);
                string Direccion = textBoxDirIn.Text;
                decimal ValorDeVenta = decimal.Parse(textBoxValorIn.Text);
                DateTime FechaDePublicacion = DateTime.Parse(textBoxPubIn.Text);
                DateTime FechaDeVenta = DateTime.Parse(textBoxFVentaIn.Text);

                gestor.AltaInmueble(new Inmueble(Id, Direccion, ValorDeVenta, FechaDePublicacion, FechaDeVenta), EmpleadoSeleccionado().Id);
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
