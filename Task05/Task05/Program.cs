using System;
using System.Net;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        { int a;
            do
            {
                Console.WriteLine("Введите длину первого катета: ");
            } while(!int.TryParse(Console.ReadLine(), out a));
            int b;
            do {

                Console.WriteLine("Введите длину второго катета: "); 
            } while(!int.TryParse(Console.ReadLine(), out b));
                int stepen = 2;

                Console.WriteLine("Гипотенуза = " + Math.Sqrt(Math.Pow(a, stepen) + Math.Pow(b, stepen)));
                Console.ReadLine();
            




        }
    }
}
