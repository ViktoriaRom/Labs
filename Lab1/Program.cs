using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Задание 1---");
            Console.WriteLine("Лабораторная работа №1: Разработка консольного приложения");
            Console.WriteLine("Выполнила: Романюк Виктория Дмитриевна");
            Console.WriteLine("Группа: 1201. Шифр специальности: 44.03.5 Педагогическое образование");
            Console.WriteLine("Дата рождения: 08.01.2003");
            Console.WriteLine("Населённый пункт: с. Биракан");
            Console.WriteLine("Любимый предмет в школе: ИЗО");
            Console.WriteLine("Хобби и интересы: рисование");

            Console.WriteLine("---Задание 2. Вариант 5---");
            double H = 0;
            double g = 6, h = 3, d17 = 27;
            int b = 13, h1 = 87, x = 9, y = -412;
            H = ((g * h) / d17) + (b / h1) - ((x + y) / 4);
            Console.WriteLine("Результат выражения H = " + H);
        }
    }
}


Ф