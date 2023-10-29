using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint3.Task7.V29.Lib;

namespace Tyuiu.SorokinMA.Sprint3.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int l = stop - start + 1;
            double[] w;
            w = new double[l];
            w[0] = -32.26;
            w[1] = -27.50;
            w[2] = -22.80;
            w[3] = -17.95;
            w[4] = -12.97;
            w[5] = -9.00;
            w[6] = -0.31;
            w[7] = 3.77;
            w[8] = 8.57;
            w[9] = 13.42;
            w[10] = 18.28;
            double[] res;
            res = new double[l];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(w, res);
        }
    }
}
