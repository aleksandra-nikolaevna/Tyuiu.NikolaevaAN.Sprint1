using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint1.Task2.V21.Lib;

namespace Tyuiu.NikolaevaAN.Sprint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 4;
            var res = ds.CalculateRectangleSquare(x, y);
            Assert.AreEqual(8, res);
        }
    }
}