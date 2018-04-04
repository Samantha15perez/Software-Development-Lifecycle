using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralCalculator
{
    class RomannumeralConverter
    {
        //this part covers Roman numeral -> number
        public static Dictionary<string, int> RomanMap = new Dictionary<string, int>()
    {
         {"I", 1},
        {"IV", 4},
        {"V", 5},
        {"IX", 9},
        {"X", 10},
        {"XL", 40},
        {"L", 50},
        {"XC", 90},
        {"C", 100},
        {"CD", 400},
        {"D", 500},
        {"CM", 900},
        {"M", 1000}

    };

        public static int RomanToInteger(string roman)
        {

            try
            {


                int number = 0;
                for (int i = 0; i < roman.Length; i++)
                {
                    if (i + 1 < roman.Length && RomanMap[roman[i].ToString()] < RomanMap[roman[i + 1].ToString()])
                    {
                        number -= RomanMap[roman[i].ToString()];
                    }
                    else
                    {
                        number += RomanMap[roman[i].ToString()];
                    }
                }
                return number;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
    class ArabicToRomanConversion
    {
        // everything past here covers number -> roman numeral
        public static Dictionary<string, int> RomanMap = new Dictionary<string, int>()
    {
         {"I", 1},
        {"IV", 4},
        {"V", 5},
        {"IX", 9},
        {"X", 10},
        {"XL", 40},
        {"L", 50},
        {"XC", 90},
        {"C", 100},
        {"CD", 400},
        {"D", 500},
        {"CM", 900},
        {"M", 1000}
    };
        public static string ArabicToRoman(int roman)
        {
            try
            {



                int inputValue = roman;
                string OutputValue = "";

                if (inputValue / 1000 >= 1)
                {
                    inputValue = (inputValue - 1000);
                    OutputValue = "M";
                }
                while (inputValue / 900 != 0)
                {
                    inputValue = (inputValue - 900);
                    OutputValue = (OutputValue + "CM");
                }
                while (inputValue / 500 != 0)
                {
                    inputValue = (inputValue - 500);
                    OutputValue = (OutputValue + "D");
                }
                while (inputValue / 400 != 0)
                {
                    inputValue = (inputValue - 400);
                    OutputValue = (OutputValue + "CD");
                }
                while (inputValue / 100 != 0)
                {
                    inputValue = (inputValue - 100);
                    OutputValue = (OutputValue + "C");
                }
                while (inputValue / 90 != 0)
                {
                    inputValue = (inputValue - 90);
                    OutputValue = (OutputValue + "XC");
                }
                while (inputValue / 50 != 0)
                {
                    inputValue = (inputValue - 50);
                    OutputValue = (OutputValue + "L");
                }
                while (inputValue / 40 != 0)
                {
                    inputValue = (inputValue - 40);
                    OutputValue = (OutputValue + "XL");
                }
                while (inputValue / 10 != 0)
                {

                    inputValue = (inputValue - 10);
                    OutputValue = (OutputValue + "X");
                }
                while (inputValue / 5 != 0)
                {
                    if (inputValue == 9)
                    {
                        inputValue = (inputValue - 9);
                        OutputValue = (OutputValue + "IX");
                    }
                    else
                    {
                        inputValue = (inputValue - 5);
                        OutputValue = (OutputValue + "V");
                    }
                }
                while (inputValue / 1 != 0)
                {
                    if (inputValue / 1 > 3)
                    {
                        inputValue = (inputValue - 4);
                        OutputValue = (OutputValue + "IV");
                    }
                    else
                    {
                        inputValue = (inputValue - 1);
                        OutputValue = (OutputValue + "I");
                    }
                }
                return OutputValue;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}

