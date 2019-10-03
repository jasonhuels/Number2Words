using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers2Words;

namespace Numbers2Words.Tests
{

    [TestClass]
    public class NumbersToWordsTests
    {
        [TestMethod]
        public void NumbersToWords_Ones_One()
        {
            int userInput = 9;
            string output = NumbersToWords.Numbers2Words(userInput);


            Assert.AreEqual(output, "nine");
        }

         [TestMethod]
         public void NumbersToWords_Tens_Ten()
        {
            int userInput = 10;
            string output = NumbersToWords.Numbers2Words(userInput);


            Assert.AreEqual(output, "ten");
        }
    }

}
