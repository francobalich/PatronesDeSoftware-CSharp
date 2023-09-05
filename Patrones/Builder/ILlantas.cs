using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface ILlantas
    {
        string informacion();
    }

    class llantas12 : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 14 pulgadas";
        }
    }
    class llantasSuper : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 18 pulgadas, rieles de aluminio";
        }
    }
}
