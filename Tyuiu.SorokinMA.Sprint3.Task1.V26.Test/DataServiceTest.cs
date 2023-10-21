using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint3.Task1.V26.Lib;

namespace Tyuiu.SorokinMA.Sprint3.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double sum = ds.GetSumSeries(3, 1, 8);
            Assert.AreEqual(4.5,sum);
        }
    }
}
