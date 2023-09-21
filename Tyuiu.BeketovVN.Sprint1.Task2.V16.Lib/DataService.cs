using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BeketovVN.Sprint1.Task2.V16.Lib
{
    public class DataService : ISprint1Task2V16
    {
        public double CalculatePerimetrCircle(int radius)
        {
            double pi = Math.PI;
            return Math.Round(2 * pi * radius,3);
        }
    }
}
//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
//Формулировка задания: Известен радиус круга. Вычислить примерный периметр круга. 