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
    public class ControllerForm1 : IABMC<EPersona>
    {
        Form Form1;
        EPersona EntPersona;
        public ControllerForm1(Form Form1)
        {
            this.Form1 = Form1;
        }

        public void Alta(EPersona Object)
        {
            throw new NotImplementedException();
        }

        public void Baja(EPersona Object)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(EPersona Object)
        {
            throw new NotImplementedException();
        }

        public void Consulta(EPersona FromObject, EPersona ToObject)
        {
            throw new NotImplementedException();
        }
    }
}
