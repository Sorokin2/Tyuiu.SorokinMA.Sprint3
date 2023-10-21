using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint3.Task2.V24.Lib;

namespace Tyuiu.SorokinMA.Sprint3.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double pr = ds.GetMultiplySeries(0.5, 1, 8);
            Assert.AreEqual(29289.154,pr);
        }
    }
}
