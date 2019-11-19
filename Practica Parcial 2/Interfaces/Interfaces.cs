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
        void ModificacionEmpleado(T empleado, string idOriginal);
        List<T> ConsultaTodos();

    }
    public interface IAMBCInmueble<T>
    {
        void AltaInmueble(T inmueble, string IdEmpleado);
        void BajaInmueble(T inmueble);
        void ModificacionInmueble(T inmueble, string idOriginal);
    }
    public interface IGuardar
    {
        void Guardar();
    }
}
