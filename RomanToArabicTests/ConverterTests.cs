using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary> Roman To Arabic Converter Testing </summary>
/// <author>Svitlana Bakun</author>
/// <project>RomanToArabicTests</project>
/// <version>1.0.0</version>

namespace RomanToArabic.Tests;

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

        Assert.AreEqual("Write valid roman number between I(1) and MMMCMXCIX(3999)", exeption.Message);
    }

    [TestMethod()]
    public void When1345_ThenArgumentException()
    {
        Exception exeption = Assert.ThrowsException<ArgumentException>(() =>
        {
            Converter.ConvertRomanToArabic("1345");
        });

        Assert.AreEqual("Write valid roman number between I(1) and MMMCMXCIX(3999)", exeption.Message);
    }

    [TestMethod()]
    public void WhenMMMM_ThenArgumentException()
    {
        Exception exeption = Assert.ThrowsException<ArgumentException>(() =>
        {
            Converter.ConvertRomanToArabic("MMMM");
        });

        Assert.AreEqual("Write valid roman number between I(1) and MMMCMXCIX(3999)", exeption.Message);
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

    [TestMethod()]
    public void WhenXVII_Then17()
    {
        Assert.AreEqual(17, Converter.ConvertRomanToArabic("XVII"));
    }

    [TestMethod()]
    public void WhenXXIV_Then24()
    {
        Assert.AreEqual(24, Converter.ConvertRomanToArabic("XXIV"));
    }

    [TestMethod()]
    public void WhenXXX_Then30()
    {
        Assert.AreEqual(30, Converter.ConvertRomanToArabic("XXX"));
    }

    [TestMethod()]
    public void WhenXLVII_Then47()
    {
        Assert.AreEqual(47, Converter.ConvertRomanToArabic("XLVII"));
    }

    [TestMethod()]
    public void WhenLVIII_Then58()
    {
        Assert.AreEqual(58, Converter.ConvertRomanToArabic("LVIII"));
    }

    [TestMethod()]
    public void WhenLXXI_Then71()
    {
        Assert.AreEqual(71, Converter.ConvertRomanToArabic("LXXI"));
    }

    [TestMethod()]
    public void WhenLXXXVIII_Then88()
    {
        Assert.AreEqual(88, Converter.ConvertRomanToArabic("LXXXVIII"));
    }

    [TestMethod()]
    public void WhenXCIX_Then99()
    {
        Assert.AreEqual(99, Converter.ConvertRomanToArabic("XCIX"));
    }

    [TestMethod()]
    public void WhenCXL_Then140()
    {
        Assert.AreEqual(140, Converter.ConvertRomanToArabic("CXL"));
    }

    [TestMethod()]
    public void WhenCXCIV_Then194()
    {
        Assert.AreEqual(194, Converter.ConvertRomanToArabic("CXCIV"));
    }

    [TestMethod()]
    public void WhenCCXLVII_Then247()
    {
        Assert.AreEqual(247, Converter.ConvertRomanToArabic("CCXLVII"));
    }

    [TestMethod()]
    public void WhenCCLXXX_Then280()
    {
        Assert.AreEqual(280, Converter.ConvertRomanToArabic("CCLXXX"));
    }

    [TestMethod()]
    public void WhenCCCXXXIII_Then333()
    {
        Assert.AreEqual(333, Converter.ConvertRomanToArabic("CCCXXXIII"));
    }

    [TestMethod()]
    public void WhenCDLXXII_Then472()
    {
        Assert.AreEqual(472, Converter.ConvertRomanToArabic("CDLXXII"));
    }

    [TestMethod()]
    public void WhenDXCIX_Then599()
    {
        Assert.AreEqual(599, Converter.ConvertRomanToArabic("DXCIX"));
    }

    [TestMethod()]
    public void WhenDCCCLVIII_Then858()
    {
        Assert.AreEqual(858, Converter.ConvertRomanToArabic("DCCCLVIII"));
    }

    [TestMethod()]
    public void WhenCMXC_Then990()
    {
        Assert.AreEqual(990, Converter.ConvertRomanToArabic("CMXC"));
    }

    [TestMethod()]
    public void WhenMCDLIV_Then1454()
    {
        Assert.AreEqual(1454, Converter.ConvertRomanToArabic("MCDLIV"));
    }

    [TestMethod()]
    public void WhenMCMXCII_Then1992()
    {
        Assert.AreEqual(1992, Converter.ConvertRomanToArabic("MCMXCII"));
    }

    [TestMethod()]
    public void WhenMMIX_Then2009()
    {
        Assert.AreEqual(2009, Converter.ConvertRomanToArabic("MMIX"));
    }

    [TestMethod()]
    public void WhenMMDCCCVI_Then2806()
    {
        Assert.AreEqual(2806, Converter.ConvertRomanToArabic("MMDCCCVI"));
    }

    [TestMethod()]
    public void WhenMMMCDXXXVI_Then3436()
    {
        Assert.AreEqual(3436, Converter.ConvertRomanToArabic("MMMCDXXXVI"));
    }

    [TestMethod()]
    public void WhenMMMCMXCIX_Then3999()
    {
        Assert.AreEqual(3999, Converter.ConvertRomanToArabic("MMMCMXCIX"));
    }
}