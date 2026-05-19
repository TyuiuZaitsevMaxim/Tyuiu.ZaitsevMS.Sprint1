using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint1.Task5.V4.Lib;

namespace Tyuiu.ZaitsevMS.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 13257;
            int expected = 3;
            int result = ds.SecondsToHours(k);
            Assert.AreEqual(expected, result);
        }
    }
}