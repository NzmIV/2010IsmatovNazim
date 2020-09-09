using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первого катета: ");
            int a;
            int.TryParse(Console.ReadLine(), out a);


            Console.WriteLine("Введите длину второго катета: ");
            int b;
            int.TryParse(Console.ReadLine(), out b);
            int stepen = 2;

            Console.WriteLine("Гипотенуза = " + Math.Sqrt(Math.Pow(a , stepen) + Math.Pow(b, stepen))); 

            Console.ReadLine();
            




        }
    }
}
