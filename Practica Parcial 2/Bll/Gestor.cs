using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DalOrm;
using Interfaces;

namespace Bll
{
    public class Gestor : IABMCEmpleado<Empleado>, IAMBCInmueble<Inmueble>, IGuardar
    {
        ServicioDal sDal = new ServicioDal();

        public void AltaEmpleado(Empleado empleado)
        {
            sDal.AltaEmpleado(empleado);
        }

        public void AltaInmueble(Inmueble inmueble, string IdEmpleado)
        {
            sDal.AltaInmueble(inmueble, IdEmpleado);
        }

        public void BajaEmpleado(Empleado empleado)
        {
            sDal.BajaEmpleado(empleado);
        }

        public void BajaInmueble(Inmueble inmueble)
        {
            sDal.BajaInmueble(inmueble);
        }

        public List<Empleado> ConsultaTodos()
        {
            return sDal.ConsultaTodos();
        }

        public void Guardar()
        {
            sDal.Guardar();
        }

        public void ModificacionEmpleado(Empleado empleado, string idOriginal)
        {
            sDal.ModificacionEmpleado(empleado, idOriginal);
        }

        public void ModificacionInmueble(Inmueble inmueble, string idOriginal)
        {
            sDal.ModificacionInmueble(inmueble, idOriginal);
        }
    }
    
}
