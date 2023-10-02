using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint1.Task6.V8.Lib;

namespace Tyuiu.BeketovVN.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string inputText = "Это тест";
            var res = ds.DeleteFirstLetter(inputText);
            Assert.AreEqual("тоЭ естт", res);
        }
    }
}
