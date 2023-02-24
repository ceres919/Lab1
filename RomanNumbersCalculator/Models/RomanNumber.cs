using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    public class RomanNumber : ICloneable, IComparable
    {
        private ushort number = 1;
        private string stringNumber = "";
        private static int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static string[] roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public RomanNumber(ushort number)
        {
            if (number < 1) throw new RomanNumberException();
            int temp = number;
            this.number = number;
            stringNumber = "";
            for (int i = 0; i < 13; i++)
            {
                while (temp >= values[i])
                {
                    temp -= (ushort)values[i];
                    stringNumber += roman[i]; 
                }
            }
            if (stringNumber.ToString() == "")
                throw new RomanNumberException();

        }
        public RomanNumber(string number)
        {
            stringNumber = number;
            number = new string(number.Reverse().ToArray());
            ushort intNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case 'M':
                        intNumber += 1000;
                        break;
                    case 'D':
                        intNumber += 500;
                        break;
                    case 'C':
                        intNumber += 100;
                        if (i > 0)
                            if (number[i - 1] == 'M' || number[i - 1] == 'D') intNumber -= 200;
                        break;
                    case 'L':
                        intNumber += 50;
                        break;
                    case 'X':
                        intNumber += 10;
                        if (i > 0)
                            if (number[i - 1] == 'C' || number[i - 1] == 'L') intNumber -= 20;
                        break;
                    case 'V':
                        intNumber += 5;
                        break;
                    case 'I':
                        intNumber += 1;
                        if (i > 0)
                            if (number[i - 1] == 'X' || number[i - 1] == 'V') intNumber -= 2;
                        break;
                }
            }
            this.number = intNumber;

            if (this.number < 1) throw new RomanNumberException();
        }
        public static RomanNumber Add(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number + RomanNumber2.number));
        }
        public static RomanNumber Sub(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number - RomanNumber2.number));
        }
        public static RomanNumber Mul(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number * RomanNumber2.number));
        }
        public static RomanNumber Div(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number / RomanNumber2.number));

        }

        public object Clone() { 
            return new RomanNumber(number); 
        }
        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber roman)
                return number.CompareTo(roman.number);
            else
                throw new RomanNumberException();
        }

        public override string ToString() => stringNumber;
        public ushort ToUInt16() => number;
    }
}
