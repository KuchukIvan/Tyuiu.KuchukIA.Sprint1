﻿using Tyuiu.KuchukIA.Sprint1.Task1.V12.Lib;
namespace Tyuiu.KuchukIA.Sprint1.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6.0;
            double y = 6.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
