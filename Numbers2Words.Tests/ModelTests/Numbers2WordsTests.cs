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
         public void NumbersToWords_Teens_Ten()
        {
            int userInput = 19;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "nineteen");
        }
        [TestMethod]
         public void NumbersToWords_Tens_NinetyNine()
        {
            int userInput = 99;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "ninety nine");
        }

        [TestMethod]
         public void NumbersToWords_Thousands_NinethousandnineHundreNinetyNine()
        {
            int userInput = 9999;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "nine thousand nine hundred ninety nine");
        }
        [TestMethod]
         public void NumbersToWords_TeenThousands_NineteenthousandnineHundreNinetyNine()
        {
            int userInput = 19999;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "nineteen thousand nine hundred ninety nine");
        }
        [TestMethod]
         public void NumbersToWords_TenThousands_NinetythousandnineHundreNinetyNine()
        {
            int userInput = 99999;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "ninety nine thousand nine hundred ninety nine");
        }
        [TestMethod]
         public void NumbersToWords_HundredThousands_NineHundredNinetythousandnineHundreNinetyNine()
        {
            int userInput = 999999;
            string output = NumbersToWords.Numbers2Words(userInput);

            Assert.AreEqual(output, "nine hundred ninety nine thousand nine hundred ninety nine");
        }
    }

}
