using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BeketovVN.Sprint1.Task3.V11.Lib
{
    public class DataService : ISprint1Task3V11
    {
        public double TriangleArea(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            double S;
            S = 0.5 * (x1 * (y2 - y3) +x2 * (y3 - y1) + x3 * (y1 - y2));

            return (Math.Abs(S));
        }
    }
}
//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
//Расчеты:
//Напишите программу, которая вычисляет площадь треугольника, если известны координаты его углов.
//Введите координаты углов (числа разделяйте пробелом):

//x1-> - 2

//y1-> 5

//х2-> 1

//у2-> 7

//хЗ-> 5

//уЗ-> - 3

//Площадь треугольника: 19 кв.см