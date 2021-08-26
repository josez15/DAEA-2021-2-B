using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, como te llamas: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, mucho gusto " + nombre);
        }
    }
}
