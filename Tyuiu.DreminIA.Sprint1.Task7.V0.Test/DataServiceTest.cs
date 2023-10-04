using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DreminIA.Sprint1.Task7.V0.Lib;

namespace Tyuiu.DreminIA.Sprint1.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ValidValues_ReturnsCorrectResult()
        {
            double x = 2.0;
            double y = 1.5;

            double expectedResult = -0.672;

            double actualResult = ExpressionCalculator.Calculate(x, y);

            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}
