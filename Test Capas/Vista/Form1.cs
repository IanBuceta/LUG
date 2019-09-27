using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;


namespace Vista
{
    public partial class Form1 : Form
    {
        Persona P = new Persona();
        MapperPersona Mp = new MapperPersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mp.Guardar(P);
        }
    }
}
