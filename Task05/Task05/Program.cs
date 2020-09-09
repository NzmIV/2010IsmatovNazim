﻿/* Шапка 
Дисциплина: "Программирование"
Группа: БПИ2010
Студент: Исматов Назим
Дата: 09.09.2020
Задача: Получить от пользователя значения длин двух катетов, вычислить и вывести на экран значение гипотенузы.
*/
using System;
using System.Net;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)

        {  //1.2 Пролог
            do
            {
                int a; // вводим целочисленную переменную
                       //2.1 ввод
                do // обуславливаем во избежания исключений 
                {
                    Console.WriteLine("Введите длину первого катета: "); // просим ввести длину катета
                } while (!int.TryParse(Console.ReadLine(), out a)); // считываем информацию с клавиатуры и парсим до нужного нам типа
                int b; // вводим целочисленную переменную 
                       //2.2 обработка

                //2.1 ввод
                do
                {  // ставим условие во избежание исключений

                    Console.WriteLine("Введите длину второго катета: ");  // просим ввести длину второго катета 
                } while (!int.TryParse(Console.ReadLine(), out b)); // считываем информацию с клавиатуры и парсим до нужного нам типа
                                                                    //2.2 обработка


                int stepen = 2; // вводим степень чтобы возвести число в квадрат
                                //2.3 Вывод
                Console.WriteLine("Гипотенуза = " + Math.Sqrt(Math.Pow(a, stepen) + Math.Pow(b, stepen))); // вывод

                //2.4 Эпилог
                Console.WriteLine("\n"); 
                Console.WriteLine("Нажмите Enter, чтобы завершить программу");
                Console.ReadLine();
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);





        }
    }
}
