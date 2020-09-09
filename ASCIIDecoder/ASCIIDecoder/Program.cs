using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число от 32 до 127:  ");
            string a = Console.ReadLine();
            int Code;
            int.TryParse(a, out Code);
            Char ch = Convert.ToChar(Code);
            Console.WriteLine(ch);
            Console.ReadLine();
           
        }
    }
}
