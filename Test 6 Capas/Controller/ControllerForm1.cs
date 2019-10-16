using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BLL;
using System.Windows.Forms;
using Interfaces;

namespace Controller
{
    public class ControllerForm1 : IABMC
    {
        Form Form1;
        EPersona ePersona;
        BPersona bPersona;
        public ControllerForm1(Form Form1)
        {
            this.Form1 = Form1;
            bPersona = new BPersona();
        }

        public EPersona PersonaSeleccionada()
        {
            DataGridView dgv = Form1.Controls["dataGridPersona"] as DataGridView;
            return dgv.SelectedRows[0].DataBoundItem as EPersona;
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
            throw new NotImplementedException();
        }

        public void Consulta()
        {
            throw new NotImplementedException();
        }

        public void ConsultaTodos()
        {
            throw new NotImplementedException();
        }
    }
}
