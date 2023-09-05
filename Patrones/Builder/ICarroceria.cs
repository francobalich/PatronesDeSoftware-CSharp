using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface ICarroceria
    {
        string caracteristicas();
    }
    class CarroceriaBasica : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carroceria de metal";
        }
    }
    class CarroceriaEspecia : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carroceria de fibra de carbono";
        }
    }
}
