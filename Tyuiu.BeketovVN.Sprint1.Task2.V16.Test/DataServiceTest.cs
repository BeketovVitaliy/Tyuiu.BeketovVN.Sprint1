using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using Tyuiu.BeketovVN.Sprint1.Task2.V16.Lib;

namespace Tyuiu.BeketovVN.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int radius = 500;
            var res = ds.CalculatePerimetrCircle(radius);
            Assert.AreEqual(3141.593, res);
        }
    }
}
