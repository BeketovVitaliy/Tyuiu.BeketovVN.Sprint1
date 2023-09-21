using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BeketovVN.Sprint1.Task3.V11.Lib;

namespace Tyuiu.BeketovVN.Sprint1.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Бекетов В. Н. | ИИПб-23-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Бекетов Виталий Николаевич | ИИПб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Вершины-1, x2, x3, y1, y2 ,y3                                           *");
            Console.WriteLine("***************************************************************************");

            double x1, x2, x3, y1, y2 ,y3;

            Console.WriteLine("Введите X1");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите X2");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите X3");
            x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y1");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y3");
            y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.TriangleArea(x1,x2,x3,y1,y2,y3));
            Console.ReadLine();
        }
    }
}
