using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint1.Task6.V15.Lib;

namespace Tyuiu.ZaitsevMS.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString_MoreLetters()
        {
            DataService ds = new DataService();
            string input = "Привет, мир!";
            bool result = ds.CheckLettersCount(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidString_MoreSigns()
        {
            DataService ds = new DataService();
            string input = "а!?,;.:";
            bool result = ds.CheckLettersCount(input);
            Assert.IsFalse(result);
        }
    }
}