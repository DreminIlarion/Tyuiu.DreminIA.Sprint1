    using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DreminIA.Sprint1.Task2.V0.Lib;

namespace Tyuiu.DreminIA.Sprint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateSeconds_ReturnsCorrectValue()
        {
            // Arrange
            int hours = 2;
            int minutes = 30;
            int expectedSeconds = 9000;

            // Act
            int actualSeconds = TimeCalculation.CalculateSeconds(hours, minutes);

            // Assert
            Assert.Equal(expectedSeconds, actualSeconds);
        }
    }
}
