using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZaitsevMS.Sprint1.Task3.V1.Lib;

namespace Tyuiu.ZaitsevMS.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
              
            Console.Title = "Спринт #1 | Выполнил: Зайцев М. С. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Зайцев Максим Сергеевич | ИБКСб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая принимает исходные данные,                  *");
            Console.WriteLine("* вычисляет объём цилиндра и выводит результат на экран.                  *");
            Console.WriteLine("* Формула: V = PI * r^2 * h                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите радиус цилиндра (r): ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту цилиндра (h): ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Объём цилиндра = " + ds.CylinderVolume(r, h));
            Console.Read();
        }
    }
}