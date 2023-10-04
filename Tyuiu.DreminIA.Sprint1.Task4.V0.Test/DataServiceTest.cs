using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DreminIA.Sprint1.Task4.V0.Lib;

namespace Tyuiu.DreminIA.Sprint1.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateResult()
        {
            // Проверка на ограниченный тестовый набор значений
            double alpha1 = 0.5;
            double expected1 = 2.546;
            Assert.AreEqual(expected1, Calculator.CalculateResult(alpha1));

            double alpha2 = 1.0;
            double expected2 = 0;
            Assert.AreEqual(expected2, Calculator.CalculateResult(alpha2));

            double alpha3 = 1.5;
            double expected3 = -3.418;
            Assert.AreEqual(expected3, Calculator.CalculateResult(alpha3));
        }
    }
}
