using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BuilderDeportivo : IBuilder
    {
        private Producto auto = new Producto();
        public void ConstrulleLlantas()
        {
            auto.ColocarLlantas(new llantasSuper());
        }

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new MotorGrande());
        }

        public void ContrulleCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaEspecia());
        }

        public Producto ObtenProducto()
        {
            return auto;
        }
    }
}
