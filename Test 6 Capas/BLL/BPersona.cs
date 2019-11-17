using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using ORM;
using Interfaces;

/// <summary>
/// BLL conoce a: Entities, ORM e Interfaces.
/// </summary>
namespace BLL
{
    public class BPersona : IABMC<EPersona>
    {
        OPersona oPersona;
        public BPersona()
        {
            oPersona = new OPersona();
        }
        public void Alta(EPersona pObject)
        {
            oPersona.Alta(pObject);
        }

        public void Baja(EPersona pObject)
        {
            oPersona.Baja(pObject);
        }

        public EPersona Consulta(EPersona pObject)
        {
            return oPersona.Consulta(pObject);
        }

        public List<EPersona> ConsultaTodos()
        {
            return oPersona.ConsultaTodos();
        }

        public void Modificacion(EPersona pObject, int IdViejo)
        {
            oPersona.Modificacion(pObject,IdViejo);
        }
    }
}
