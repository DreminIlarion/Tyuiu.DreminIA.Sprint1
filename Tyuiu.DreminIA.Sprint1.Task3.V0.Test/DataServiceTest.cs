using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DreminIA.Sprint1.Task3.V0.Lib;

namespace Tyuiu.DreminIA.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertToHoursAndMinutes_ConvertsCorrectly()
        {
            int minutes = 150;
            string expected = "2 ч. 30 мин.";

            string actual = TimeIntervalConverter.ConvertToHoursAndMinutes(minutes);

            Assert.Equal(expected, actual);
        }
    }
}
