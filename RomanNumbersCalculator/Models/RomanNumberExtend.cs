using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    public class RomanNumberExtend : RomanNumber
    {
        public RomanNumberExtend(ushort n) : base(n) { }
        public RomanNumberExtend(string n) : base(n) { }

        public static RomanNumberExtend operator +(RomanNumberExtend RomanNumber1, RomanNumberExtend RomanNumber2)
        {
            int numb = RomanNumber1.ToUInt16() + RomanNumber2.ToUInt16();
            if (numb <= 0)
                throw new RomanNumberException();
            else
                return new RomanNumberExtend((ushort)(RomanNumber1.ToUInt16() + RomanNumber2.ToUInt16()));
        }

        public static RomanNumberExtend operator -(RomanNumberExtend RomanNumber1, RomanNumberExtend RomanNumber2)
        {
            int numb = RomanNumber1.ToUInt16() - RomanNumber2.ToUInt16();
            if (numb <= 0)
                throw new RomanNumberException();
            else
                return new RomanNumberExtend((ushort)(RomanNumber1.ToUInt16() - RomanNumber2.ToUInt16()));
        }

        public static RomanNumberExtend operator *(RomanNumberExtend RomanNumber1, RomanNumberExtend RomanNumber2)
        {
            int numb = RomanNumber1.ToUInt16() * RomanNumber2.ToUInt16();
            if (numb <= 0)
                throw new RomanNumberException();
            else
                return new RomanNumberExtend((ushort)(RomanNumber1.ToUInt16() * RomanNumber2.ToUInt16()));
        }

        public static RomanNumberExtend operator /(RomanNumberExtend RomanNumber1, RomanNumberExtend RomanNumber2)
        {
            if (RomanNumber1.ToUInt16() == 0)
                throw new RomanNumberException();
            else
            {
                int numb = RomanNumber1.ToUInt16() / RomanNumber2.ToUInt16();
                if (numb == 0)
                    throw new RomanNumberException();
                else
                    return new RomanNumberExtend((ushort)(RomanNumber1.ToUInt16() / RomanNumber2.ToUInt16()));
            }
        }
    }
}
