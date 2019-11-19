using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IABMCEmpleado<T>
    {
        void AltaEmpleado(T empleado);        
        void BajaEmpleado(T empleado);
        void ModificacionEmpleado(T empleado, int idOriginal);       
        List<T> ConsultaTodos();

    }
    public interface IAMBCInmueble<T>
    {
        void AltaInmueble(T inmueble);
        void BajaInmueble(T inmueble);
        void ModificacionInmueble(T inmueble, int idOriginal);
        List<T> ConsultaInmuebles(T empleado);
    }
}
