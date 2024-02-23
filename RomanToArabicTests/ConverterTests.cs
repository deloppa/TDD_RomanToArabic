using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToArabic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToArabic.Tests
{
    [TestClass()]
    public class ConverterTests
    {
        [TestMethod()]
        public void WhenEmpty_ThenArgumentException()
        {
            Exception exeption = Assert.ThrowsException<ArgumentException>(() => 
            {
                 Converter.ConvertRomanToArabic("");
            });

            Assert.AreEqual("String cannot be empty", exeption.Message);
        }

        [TestMethod()]
        public void WhenVII_I_ThenArgumentException()
        {
            Exception exeption = Assert.ThrowsException<ArgumentException>(() =>
            {
                Converter.ConvertRomanToArabic("VII_I");
            });

            Assert.AreEqual("Write valid roman number between 1 and 3999", exeption.Message);
        }

        [TestMethod()]
        public void When1345_ThenArgumentException()
        {
            Exception exeption = Assert.ThrowsException<ArgumentException>(() =>
            {
                Converter.ConvertRomanToArabic("1345");
            });

            Assert.AreEqual("Write valid roman number between 1 and 3999", exeption.Message);
        }

        [TestMethod()]
        public void WhenMMMM_ThenArgumentException()
        {
            Exception exeption = Assert.ThrowsException<ArgumentException>(() =>
            {
                Converter.ConvertRomanToArabic("MMMM");
            });

            Assert.AreEqual("Write valid roman number between 1 and 3999", exeption.Message);
        }

        [TestMethod]
        public void WhenI_Then1()
        {
            Assert.AreEqual(1, Converter.ConvertRomanToArabic("I"));
        }

        [TestMethod]
        public void WhenIV_Then4()
        {
            Assert.AreEqual(4, Converter.ConvertRomanToArabic("IV"));
        }

        [TestMethod]
        public void WhenV_Then5()
        {
            Assert.AreEqual(5, Converter.ConvertRomanToArabic("V"));
        }

        [TestMethod]
        public void WhenIX_Then9()
        {
            Assert.AreEqual(9, Converter.ConvertRomanToArabic("IX"));
        }

        [TestMethod]
        public void WhenX_Then10()
        {
            Assert.AreEqual(10, Converter.ConvertRomanToArabic("X"));
        }

        [TestMethod]
        public void WhenXL_Then40()
        {
            Assert.AreEqual(40, Converter.ConvertRomanToArabic("XL"));
        }

        [TestMethod]
        public void WhenL_Then50()
        {
            Assert.AreEqual(50, Converter.ConvertRomanToArabic("L"));
        }

        [TestMethod]
        public void WhenXC_Then90()
        {
            Assert.AreEqual(90, Converter.ConvertRomanToArabic("XC"));
        }

        [TestMethod]
        public void WhenC_Then100()
        {
            Assert.AreEqual(100, Converter.ConvertRomanToArabic("C"));
        }

        [TestMethod]
        public void WhenCD_Then400()
        {
            Assert.AreEqual(400, Converter.ConvertRomanToArabic("CD"));
        }

        [TestMethod]
        public void WhenD_Then500()
        {
            Assert.AreEqual(500, Converter.ConvertRomanToArabic("D"));
        }

        [TestMethod]
        public void WhenCM_Then900()
        {
            Assert.AreEqual(900, Converter.ConvertRomanToArabic("CM"));
        }

        [TestMethod]
        public void WhenM_Then1000()
        {
            Assert.AreEqual(1000, Converter.ConvertRomanToArabic("M"));
        }
    }
}