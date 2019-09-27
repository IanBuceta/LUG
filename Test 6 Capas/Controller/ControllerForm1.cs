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

        public void Alta()
        {
            int Id = int.Parse(Form1.Controls["textBoxId"].Text);
            string Nombre = Form1.Controls["textBoxNombre"].Text;
            string Apellido = Form1.Controls["textBoxApellido"].Text;
            EPersona epersona = new EPersona(Id, Nombre, Apellido);
            bPersona.Alta();
        }

        public void Baja()
        {
            throw new NotImplementedException();
        }

        public void Modificacion()
        {
            throw new NotImplementedException();
        }

        public void Consulta()
        {
            throw new NotImplementedException();
        }
    }
}
