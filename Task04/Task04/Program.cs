using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Введите значение напряжения U: ");
            int u;
            int.TryParse(Console.ReadLine(), out u);
            
            Console.WriteLine("Введите значение сопротивления R: ");
            int r;
            int.TryParse(Console.ReadLine(), out r);

            Console.WriteLine("Сила тока I = " + (u / r));
            int stepen = 2;
            Math.Pow(u, stepen);
            Console.WriteLine("Потребляемая мощность P = " + (Math.Pow(u,stepen) / r));
            Console.ReadLine(); 
                      
        }
    }
}
