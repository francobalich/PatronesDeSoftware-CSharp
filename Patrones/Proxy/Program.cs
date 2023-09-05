using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CProxy.ISujeto miProxy = new CProxy.ProxySencillo();

            miProxy.Peticion(1);
            Console.WriteLine("----");
            miProxy.Peticion(2);
            Console.WriteLine("----");

            CProxy.ISujeto miProxySeguro = new CProxy.ProxySeguro();

            miProxySeguro.Peticion(1);
            Console.WriteLine("----");
            miProxySeguro.Peticion(2);
            Console.WriteLine("----");
            Console.ReadLine();
        }
    }
}
