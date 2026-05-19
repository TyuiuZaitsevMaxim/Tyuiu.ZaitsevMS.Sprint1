using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint1.Task2.V16.Lib;

namespace Tyuiu.ZaitsevMS.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    { 
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 5;
            var res = ds.CalculatePerimetrCircle(r);
            Assert.AreEqual(31.416, res);
        }
    }
}