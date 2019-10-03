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
        [TestMethod]
         public void NumbersToWords_NinetyNine_NinetyNine()
        {
            int userInput = 99;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "ninety nine");
        }

        [TestMethod]
         public void NumbersToWords_NinethousandnineHundreNinetyNine_NinethousandnineHundreNinetyNine()
        {
            int userInput = 9999;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "nine thousand nine hundred ninety nine");
        }
        [TestMethod]
         public void NumbersToWords_NineteenthousandnineHundreNinetyNine_NineteenthousandnineHundreNinetyNine()
        {
            int userInput = 19999;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "nineteen thousand nine hundred ninety nine");
        }
        [TestMethod]
         public void NumbersToWords_NinetyninethousandnineHundreNinetyNine_NinetythousandnineHundreNinetyNine()
        {
            int userInput = 99999;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "ninety nine thousand nine hundred ninety nine");
        }
        [TestMethod]
         public void NumbersToWords_NineHundredNinetyninethousandnineHundreNinetyNine_NineHundredNinetythousandnineHundreNinetyNine()
        {
            int userInput = 999999;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "nine hundred ninety nine thousand nine hundred ninety nine");
        }
    }

}
