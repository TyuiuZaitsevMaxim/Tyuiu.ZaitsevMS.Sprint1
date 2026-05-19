using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint1.Task7.V4.Lib;

namespace Tyuiu.ZaitsevMS.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 3;
            double inner = (y - Math.Sqrt(Math.Abs(x))) * (x - y / (x + Math.Pow(x, 2) / 4));
            double expected = Math.Round(Math.Log(Math.Abs(inner)), 3);
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result);
        }
    }
}