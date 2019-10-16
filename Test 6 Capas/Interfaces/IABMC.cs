using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IABMC
    {
        void Alta();
        void Baja();
        void Modificacion();
        void Consulta();
        void ConsultaTodos();
    }
    public interface IABMC<T>
    {
        void Alta();
        void Baja();
        void Modificacion();
        void Consulta();
        void ConsultaTodos();
    }
}
