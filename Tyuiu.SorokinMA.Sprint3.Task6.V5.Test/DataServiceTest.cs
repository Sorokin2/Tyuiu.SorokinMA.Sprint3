using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint3.Task6.V5.Lib;

namespace Tyuiu.SorokinMA.Sprint3.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int sum = ds.GetSumTheDivisors(3, 8);
            Assert.AreEqual(52, sum);
        }
    }
}
