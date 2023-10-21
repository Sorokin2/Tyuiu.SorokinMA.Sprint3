using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinMA.Sprint3.Task2.V24.Lib;

namespace Tyuiu.SorokinMA.Sprint3.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double a = 0.25;
            int b = 1;
            int c = 8;
            Console.Title = "Спринт #3 | Выполнил: Сорокин М. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Сорокин Михаил Анатольевич | ПКТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле, при a=0,25                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Переменная A = "+a);
            Console.WriteLine("Старт шага = "+b);
            Console.WriteLine("Конец шага = "+c);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(a,b,c));
            Console.ReadKey();
        }
    }
}
