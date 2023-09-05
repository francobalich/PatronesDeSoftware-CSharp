using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        public void Construye(IBuilder pConstructor)
        {
            pConstructor.ConstrulleLlantas();
            pConstructor.ConstrulleMotor();
            pConstructor.ContrulleCarroceria();
        }
    }
}
