using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapida = new List<int>();

            CFlyweightFactory flywf = new CFlyweightFactory();

            int i = 0;

            i = flywf.Adicionat("Hamburguesa");
            Americana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adicionat("Wisconsin cheese");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adicionat("Minestrone");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flywf.Adicionat("Antipasto");
            Ensaladas.Add(i);
            Italiana.Add(i);

            i = flywf.Adicionat("Tacos al pastor");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adicionat("Coditos");
            Mexicana.Add(i);
            Sopas.Add(i);

            foreach (int n in Rapida)
            {
                CReceta receta = (CReceta)flywf[n];
                receta.CalcularCosto();
                receta.Mostrar();

            }
            Console.WriteLine("-----");


            Console.ReadLine();
        }
    }
}
