using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director miDirector = new Director();

            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);
            Producto auto = normal.ObtenProducto();

            auto.MostrarAuto();
            Console.WriteLine("----");

            BuilderDeportivo deportivo = new BuilderDeportivo();

            miDirector.Construye(deportivo);

            Producto auto2 = deportivo.ObtenProducto();

            auto2.MostrarAuto();

            Console.ReadLine();
        }
    }
    
}
