using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static CareTaker caretaker = new CareTaker();
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Franco";
            caretaker.Add(persona.saveToMemento());

            persona.Nombre = "Juan";
            caretaker.Add(persona.saveToMemento());

            persona.Nombre = "Pedro";
            caretaker.Add(persona.saveToMemento());

            Memento m1 = caretaker.GetMemento(0);
            Console.WriteLine("Viendo memento 1: " + m1.Estado);
            Console.WriteLine("Viendo memento 2: " + caretaker.GetMemento(1).Estado);
            Console.WriteLine("Viendo memento 3: " + caretaker.GetMemento(2).Estado);

            persona.restoreToMemento(m1);
            persona.restoreToMemento(caretaker.GetMemento(1));
            Console.ReadKey();
        }
    }
}
