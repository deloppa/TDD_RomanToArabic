using System.Text.RegularExpressions;

/// <summary> Roman To Arabic Converter </summary>
/// <author>Svitlana Bakun</author>
/// <project>RomanToArabic</project>
/// <version>1.0.0</version>

namespace RomanToArabic;
public static class Converter
{
    private static Dictionary<string, int> _values = new Dictionary<string, int>()
    {
        { "I", 1 },
        { "IV", 4 },
        { "V", 5 },
        { "IX", 9 },
        { "X", 10 },
        { "XL", 40 },
        { "L", 50 },
        { "XC", 90 },
        { "C", 100 },
        { "CD", 400 },
        { "D", 500 },
        { "CM", 900 },
        { "M", 1000 }
    };

    public static int ConvertRomanToArabic(string roman)
    {
        roman = roman.ToUpper();

        if (roman.Equals("")) throw new ArgumentException("String cannot be empty");

        if(!IsValid(roman)) throw new ArgumentException("Write valid roman number between I(1) and MMMCMXCIX(3999)");

        if (_values.ContainsKey(roman)) return _values[roman];

        int result = 0;

        while(roman.Length > 0)
        {
            if(roman.Length >= 2)
            {
                string twoChars = roman.Substring(0, 2);
                if (_values.ContainsKey(twoChars))
                {
                    result += _values[twoChars];
                    roman = roman.Substring(2);

                    continue;
                }
            }

            string oneChar = roman.Substring(0, 1);
            result += _values[oneChar];
            roman = roman.Substring(1);

        }


        return result;
    }

    private static bool IsValid(string roman)
    {
        string pattern = @"^(M{0,3})(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(roman);
    }
}
