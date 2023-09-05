using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productos = new Dictionary<string, double>();

            productos.Add("M1", 1000);
            productos.Add("A2", 2000);
            productos.Add("A3", 3000);
            productos.Add("A4", 1500);
            productos.Add("M5", 1800);
            productos.Add("M6", 1900);
            productos.Add("M7", 10000);


            CAbstraccion abstraccion1 = new CAbstraccion(new CImplementacion(), productos);
            abstraccion1.MostrarTotales();
            Console.WriteLine();

            CAbstraccion abstraccion2 = new CAbstraccion(new CImplementacion2(), productos);
            abstraccion2.MostrarTotales();
            Console.WriteLine();

            CAbstraccion abstraccion3 = new CAbstraccion(new CImplementacion3(), productos);
            abstraccion3.MostrarTotales();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
    
    
}
