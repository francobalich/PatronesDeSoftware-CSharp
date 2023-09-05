using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipe
{
    public class CAdminPrototipe
    {
        private Dictionary<string, IProtoripe> prototipos = new Dictionary<string, IProtoripe>();

        public CAdminPrototipe()
        {
            CValores valores = new CValores(10);
            prototipos.Add("Valores", valores);
        }

        public void AdicionarPrototipos(string pLlave, IProtoripe pPrototipe)
        {
            prototipos.Add(pLlave, pPrototipe);
        }
        public object ObtenPrototipo(string pLlave)
        {
            return prototipos[pLlave].Clonar();
        }
    }
}
