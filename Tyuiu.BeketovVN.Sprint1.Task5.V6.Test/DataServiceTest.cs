using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Channels;
using Tyuiu.BeketovVN.Sprint1.Task5.V6.Lib;

namespace Tyuiu.BeketovVN.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 8;
            var res = ds.Calculate(k);
            Assert.AreEqual(1, res);
        }
    }
}
