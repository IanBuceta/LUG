using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

/// <summary>
/// Vista solo conoce al controlador.
/// </summary>
namespace VL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        ControllerForm1 ControllerF1;
        private void Form1_Load(object sender, EventArgs e)
        {
            ControllerF1 = new ControllerForm1(this);
            ControllerF1.Mostrar();
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                ControllerF1.Alta();
                ControllerF1.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                ControllerF1.Baja();
                ControllerF1.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ControllerF1.Modificacion();
                ControllerF1.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridPersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ControllerF1.CeldaSeleccionada();
                ControllerF1.Consulta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
