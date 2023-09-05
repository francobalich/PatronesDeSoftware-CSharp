using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BuilderNormal:IBuilder
    {
        private Producto auto = new Producto();
        public void ConstrulleLlantas()
        {
            auto.ColocarLlantas(new llantas12());
        }

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }

        public void ContrulleCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }

        public Producto ObtenProducto()
        {
            return auto;
        }
    }
}
