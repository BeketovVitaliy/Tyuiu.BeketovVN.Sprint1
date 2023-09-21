using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint1.Task3.V11.Lib;

namespace Tyuiu.BeketovVN.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = -2, x2 = 1, x3 = 5, y1 = 5, y2 = 7, y3 = -3;
            var res = ds.TriangleArea(x1,x2,x3,y1,y2,y3);
            Assert.AreEqual(19, res);
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