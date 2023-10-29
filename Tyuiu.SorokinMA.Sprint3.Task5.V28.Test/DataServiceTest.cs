using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint3.Task5.V28.Lib;

namespace Tyuiu.SorokinMA.Sprint3.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int a = 1, b = 1, c = 3, d = 12;
            var res = ds.GetSumSumSeries(x, a, b, c, d);
            double wait = -1032.182;
            Assert.AreEqual(wait, res);
        }
    }
}
