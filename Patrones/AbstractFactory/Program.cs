using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizzeria fabrica;
            fabrica = new PizzeriaArgentina();

            Pizza pizza = fabrica.CrearPizza();
            Empanada empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"{pizza.ToString()}, {empanada.ToString()}");

            fabrica = new PizzeriaItaliana();
            pizza = fabrica.CrearPizza();
            empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"{pizza.ToString()}, {empanada.ToString()}");

            fabrica = new PizzeriaEspañola();
            pizza = fabrica.CrearPizza();
            empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"{pizza.ToString()}, {empanada.ToString()}");

            Console.ReadKey();
        }
    }
}
