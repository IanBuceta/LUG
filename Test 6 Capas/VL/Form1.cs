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
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                ControllerF1.Alta();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
