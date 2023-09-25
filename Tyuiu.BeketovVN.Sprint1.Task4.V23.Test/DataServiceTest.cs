using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint1.Task4.V23.Lib;


namespace Tyuiu.BeketovVN.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double x = 1, y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.577, res);
        }
    }
}
