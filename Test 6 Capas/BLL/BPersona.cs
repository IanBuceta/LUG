using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using ORM;
using Interfaces;

namespace BLL
{
    public class BPersona : IABMC
    {
        OPersona oPersona;
        public BPersona()
        {
            oPersona = new OPersona();
        }
        public void Alta()
        {
            try
            {
                oPersona.Alta();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Baja()
        {
            throw new NotImplementedException();
        }

        public void Consulta()
        {
            throw new NotImplementedException();
        }

        public void Modificacion()
        {
            throw new NotImplementedException();
        }
    }
}
