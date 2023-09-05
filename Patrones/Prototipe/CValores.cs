using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipe
{
    public class CValores : IProtoripe
    {
        private double sumatoria;
        private int m = 1;

        public int M { get => m; set => m = value; }
        public double Sumatoria { get => sumatoria; set => sumatoria = value; }

        public CValores()
        {

        }

        public CValores(int pM)
        {
            m = pM;
            for (int i = 0; i < 90; i++)
            {
                sumatoria += Math.Sin(i * 0.0175);
            }
        }
        public override string ToString()
        {
            return string.Format("{0}", sumatoria * m);
        }
        public object Clonar()
        {
            CValores clon = new CValores();
            clon.M = m;
            clon.sumatoria = sumatoria;
            return clon;
        }
    }
}
