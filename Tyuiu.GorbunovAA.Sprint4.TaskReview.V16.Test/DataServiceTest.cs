using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint4.TaskReview.V16.Lib;

namespace Tyuiu.GorbunovAA.Sprint4.TaskReview.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string res = "382976421897948";
            var otvet = ds.Calculate(5, 3, res);
            Assert.AreEqual(otvet, 196608);
        }
    }
}
