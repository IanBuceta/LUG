using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BLL;
using System.Windows.Forms;
using Interfaces;

/// <summary>
/// Controller conoce a: Entities, BLL e interfaces (y vista)
/// </summary>

namespace Controller
{
    public class ControllerForm1 : IABMC
    {
        Form Form1;
        BPersona bPersona;
        DataGridView Dgv;
        public ControllerForm1(Form Form1)
        {
            this.Form1 = Form1;
            bPersona = new BPersona();
            Dgv = Form1.Controls["dataGridPersona"] as DataGridView;
        }

        public EPersona PersonaSeleccionada()
        {            
            return Dgv.SelectedRows[0].DataBoundItem as EPersona;
        }
        public void Mostrar()
        {
            Dgv.DataSource = null;
            Dgv.DataSource = bPersona.ConsultaTodos();
        }
        public void Alta()
        {
            int Id = int.Parse(Form1.Controls["textBoxId"].Text);
            string Nombre = Form1.Controls["textBoxNombre"].Text;
            string Apellido = Form1.Controls["textBoxApellido"].Text;
            EPersona epersona = new EPersona(Id, Nombre, Apellido);
            bPersona.Alta(epersona);
        }

        public void Baja()
        {
            bPersona.Baja(PersonaSeleccionada());
        }

        public void Modificacion()
        {
            int Id = int.Parse(Form1.Controls["textBoxId"].Text);
            string Nombre = Form1.Controls["textBoxNombre"].Text;
            string Apellido = Form1.Controls["textBoxApellido"].Text;
            EPersona epersona = new EPersona(Id, Nombre, Apellido);
            bPersona.Modificacion(epersona, PersonaSeleccionada().Id);
        }

        public void Consulta()
        {
            EPersona persona = bPersona.Consulta(PersonaSeleccionada());
            if (persona != null)
            {
                MessageBox.Show($"Id: {persona.Id}\nNombre: {persona.Nombre}\nApellido: {persona.Apellido}");
            }
        }

        public void CeldaSeleccionada()
        {
            Form1.Controls["textBoxId"].Text = PersonaSeleccionada().Id.ToString();
            Form1.Controls["textBoxNombre"].Text = PersonaSeleccionada().Nombre;
            Form1.Controls["textBoxApellido"].Text = PersonaSeleccionada().Apellido;
        }

        public void ConsultaTodos()
        {
            throw new NotImplementedException();
        }
    }
}
