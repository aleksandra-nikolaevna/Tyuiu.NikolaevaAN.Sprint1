using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint1.Task7.V13.Lib;

namespace Tyuiu.NikolaevaAN.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
    }
}