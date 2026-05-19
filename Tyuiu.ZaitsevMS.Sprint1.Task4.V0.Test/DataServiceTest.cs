using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint1.Task4.V16.Lib;

namespace Tyuiu.ZaitsevMS.Sprint1.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double expected = Math.Round(1.0 / (x + 4), 3);
            var result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }
    }
}