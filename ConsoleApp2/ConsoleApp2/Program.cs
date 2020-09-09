using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int x, y;    // целочисленные переменные 
            Console.Write("Целое число: ");  // ввод представления первого числа
            string InputStr = Console.ReadLine(); // чтения с клавиатуры
            int.TryParse(InputStr, out x);  // переводим на тип int, убирая исключения

            Console.Write("Целое число: "); // ввод представления второго числа 
            InputStr = Console.ReadLine(); // чтение с клавиатуры 
            int.TryParse(InputStr, out y); // переводим на тип int, убирая исключения 

            Console.WriteLine("Ваш текст:" + (x - y));  // вывод
            Console.WriteLine("Умножение: " + x * y);
            Console.WriteLine("Деление: " + x / y);
            Console.WriteLine("Забыл: " + x%y);
            Console.WriteLine("Сдвиг влево: " + (x << y));
            Console.WriteLine("Сдвиг вправо: " + (x>> y));
            Console.ReadKey();


        }
    }
}
