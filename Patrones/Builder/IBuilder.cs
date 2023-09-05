using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        void ConstrulleMotor();
        void ContrulleCarroceria();
        void ConstrulleLlantas();
    }
}
