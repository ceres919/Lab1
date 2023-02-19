using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    public class RomanNumber : ICloneable, IComparable
    {
        private ushort _number;
        private static int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static string[] roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public RomanNumber(ushort numb)
        {
            if (numb <= 0)
                throw new RomanNumberException();
            else this._number = numb;
        }

        public static RomanNumber operator +(RomanNumber? numb1, RomanNumber? numb2)
        {
            int numb = numb1._number + numb2._number;
            if (numb <= 0)
                throw new RomanNumberException();
            else
                return new RomanNumber((ushort)numb);
        }

        public static RomanNumber operator -(RomanNumber? numb1, RomanNumber? numb2)
        {
            int numb = numb1._number - numb2._number;
            if (numb <= 0)
                throw new RomanNumberException();
            else
                return new RomanNumber((ushort)numb);
        }

        public static RomanNumber operator *(RomanNumber? numb1, RomanNumber? numb2)
        {
            int numb = numb1._number * numb2._number;
            if (numb <= 0)
                throw new RomanNumberException();
            else
                return new RomanNumber((ushort)numb);
        }

        public static RomanNumber operator /(RomanNumber? numb1, RomanNumber? numb2)
        {
            if (numb2._number == 0)
                throw new RomanNumberException();
            else
            {
                int numb = numb1._number / numb2._number;
                if (numb == 0)
                    throw new RomanNumberException();
                else
                    return new RomanNumber((ushort)numb);
            }
        }
        public object Clone() { 
            return new RomanNumber(_number); 
        }
        public int CompareTo(object obj)
        {
            if (obj is RomanNumber roman)
                return _number.CompareTo(roman._number);
            else
                throw new RomanNumberException();
        }

        public override string ToString()
        {
            int temp = _number;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 13; i++)
            {
                while (temp >= values[i])
                {
                    temp -= (ushort)values[i];
                    result.Append(roman[i]);
                }
            }
            if (result.ToString() == "")
                throw new RomanNumberException();
            else
                return result.ToString();
        }
    }
}
