using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint1.Task1.V30.Lib;

namespace Tyuiu.ZaitsevMS.Sprint1.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            double x = 4.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(3.0, res);
        }
    }
}