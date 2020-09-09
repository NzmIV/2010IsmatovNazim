/* Шапка
 Дисциплина: "Программирование"
 Группа: БПИ2010
 Студент: Исматов Назим
 Дата: 09.09.2020
 Задача: Получить от пользователя значения напряжения U и сопротивления R, вычислить силу тока  I = U/R и потребляемую мощность  P = U2/R электрической цепи.
*/
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
