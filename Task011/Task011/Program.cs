using System;

namespace Task011
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите первое слово: "); // Ввод представления первого слова.
            string n;
            n = Console.ReadLine(); // считывание с клавиатуры строки.
            Console.WriteLine("введите второе слово: "); // Ввод представления второго слова.\\\
            string m;
            m = Console.ReadLine(); // считывание второго слова с клавиатуры строки.
            Console.WriteLine("введите третье слово: ");  // Ввод представления третьего слова.
            string k;
            k = Console.ReadLine(); // считывание третьего слова с клавиатуры строки.

            Console.WriteLine("\n-" + n + "-" + "\n-"+ m+"-" +"\n-"+ k + "-"); // Вывод
             
        }
    }
}
