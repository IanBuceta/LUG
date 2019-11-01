using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VL
{
    public partial class Paginador : UserControl
    {
        Gestor Ges = new Gestor();
        public Paginador()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(Input("Id", ""));
                string Nombre = Input("Nombre", "");
                string Apellido = Input("Apellido", "");
                Ges.Agregar(new Persona(Id, Nombre, Apellido));
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Ges.Borrar(PersonaSeleccionada());
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private Persona PersonaSeleccionada()
        {
            return dataGridView1.SelectedRows[0].DataBoundItem as Persona;
        }

        private string Input(string Texto, string Default)
        {
            return Interaction.InputBox(Texto + ':', "", Default);
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Ges.VerPersonas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelStart.Text != "0")
                {
                    labelStart.Text = (int.Parse(labelStart.Text) - 10).ToString();
                    labelEnd.Text = (int.Parse(labelEnd.Text) - 10).ToString();
                }                
                Ges.FillTable(int.Parse(labelStart.Text), int.Parse(labelEnd.Text));
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                labelStart.Text = (int.Parse(labelStart.Text) + 10).ToString();
                labelEnd.Text = (int.Parse(labelEnd.Text) + 10).ToString();
                Ges.FillTable(int.Parse(labelStart.Text), int.Parse(labelEnd.Text));
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Paginador_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Ges.Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
