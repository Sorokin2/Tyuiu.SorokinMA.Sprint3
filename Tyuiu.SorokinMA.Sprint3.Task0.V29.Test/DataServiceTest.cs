using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint3.Task0.V29.Lib;

namespace Tyuiu.SorokinMA.Sprint3.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double t = 0.3;
            int a = 1, b = 10;
            double sum = ds.GetSumSeries(t, a, b);
            Assert.AreEqual(0.094, sum);

        }
    }
}
