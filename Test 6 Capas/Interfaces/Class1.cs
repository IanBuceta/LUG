using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IABMC <T>
    {
        void Alta(T Object);
        void Baja(T Object);
        void Modificacion(T Object);
        void Consulta(T FromObject, T ToObject);
    }
}
