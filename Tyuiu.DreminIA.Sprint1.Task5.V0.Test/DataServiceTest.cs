using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DreminIA.Sprint1.Task5.V0.Lib;

namespace Tyuiu.DreminIA.Sprint1.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateHours()
        {
            // Угол поворота стрелки на 90 градусов
            double angle = 90;
            double expectedHours = 3;

            double actualHours = ClockCalculator.CalculateHours(angle);

            Assert.AreEqual(expectedHours, actualHours);
        }
    }
}
