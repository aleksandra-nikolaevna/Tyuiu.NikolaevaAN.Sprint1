using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint1.Task1.V21.Lib;

namespace Tyuiu.NikolaevaAN.Sprint1.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.0, res);
        }
    }
}