using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint1.Task5.V0.Lib;

namespace Tyuiu.NikolaevaAN.Sprint1.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 271;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);
            int result = Convert.ToInt32(res);
            int wait = 9;
            Assert.AreEqual(wait, result);
        }
    }
}