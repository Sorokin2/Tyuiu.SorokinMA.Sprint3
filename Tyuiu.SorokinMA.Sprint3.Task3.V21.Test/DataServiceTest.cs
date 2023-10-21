using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint3.Task3.V21.Lib;

namespace Tyuiu.SorokinMA.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string str = "7 l7ke Sp2r4n";
            Assert.AreEqual("i like Spirin", ds.ReplaceNumOnChar(str, 'i'));
        }
    }
}
