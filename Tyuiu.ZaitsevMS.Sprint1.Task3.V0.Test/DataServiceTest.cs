using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint1.Task3.V1.Lib;

namespace Tyuiu.ZaitsevMS.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 3;
            double h = 5;
            double expected = Math.Round(Math.PI * r * r * h, 3);
            var result = ds.CylinderVolume(r, h);
            Assert.AreEqual(expected, result);
        }
    }
}