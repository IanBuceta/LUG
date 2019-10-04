﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_PreParcial
{
    public partial class Form1 : Form
    {
        List<Persona> Personas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataGridView dg in this.Controls)
            {
                dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
        public string Input(string Text)
        {
            return Interaction.InputBox(Text + ':');
        }
        private void AltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string DNI = Input("DNI");
                if (Personas.Exists(x => x.DNI == DNI)) throw new Exception("El DNI ingresado ya existe");

                string Nombre = Input("Nombre");
                string Apellido = Input("Apellido");
                Personas.Add(new Persona(DNI, Nombre, Apellido));

                while (MessageBox.Show("Ingresar Compras?", "", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    int Id = int.Parse(Input("Id"));
                    decimal Importe = decimal.Parse(Input("Importe"));
                    Personas.Last().CargarCompra(new Compra(Id, Importe));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);;
            }
        }
        private void Mostrar(DataGridView Dgv, object O)
        {
            Dgv.DataSource = null;
            Dgv.DataSource = O;
        }
    }
}
