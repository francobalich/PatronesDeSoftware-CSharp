using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CAdminPrototipe admin = new CAdminPrototipe();

            CValores uno = (CValores)admin.ObtenPrototipo("Valores");
            Console.Write("Valor:");
            Console.WriteLine(uno);
            Console.ReadLine();

        }
    }
}
