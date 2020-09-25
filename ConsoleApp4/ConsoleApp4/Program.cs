using System;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            if(!double.TryParse(Console.ReadLine(), out x) || !double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                bool result = (Math.Pow(x, 2) + Math.Pow(y, 2) <= 2) && (Math.Pow(x, 2) + Math.Pow(y, 2) >= 1);
                Console.WriteLine(result);
            }
        }
    }
}