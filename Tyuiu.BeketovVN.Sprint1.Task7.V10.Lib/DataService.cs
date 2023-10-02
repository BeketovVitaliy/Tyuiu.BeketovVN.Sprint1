using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BeketovVN.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double angle = 3 * x;
            double ctg = 1.0 / Math.Tan(angle);
            double numerator = Math.Log(Math.Cos(x));
            double denominator = Math.Log(1 + Math.Pow(x, 2));
            double z = 2 * ctg - (numerator / denominator);
            return Math.Round(z,3);
        }
    }
}
