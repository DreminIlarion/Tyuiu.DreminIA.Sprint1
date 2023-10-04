using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DreminIA.Sprint1.Task6.V0.Lib;

namespace Tyuiu.DreminIA.Sprint1.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            var wordManipulator = new WordManipulator();
            string word = "example";

            string modifiedWord = wordManipulator.ModifyWord(word);

            Assert.AreEqual("xamplee", modifiedWord);
        }
    }
}
