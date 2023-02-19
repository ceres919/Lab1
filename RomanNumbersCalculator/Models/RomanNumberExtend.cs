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
        public static ushort ToInt(string? stringNumb)
        {
            
            stringNumb = new string(stringNumb.Reverse().ToArray());
            ushort intNumb = 0;
            for (int i = 0; i < stringNumb.Length; i++)
            {
                switch (stringNumb[i])
                {
                    case 'M':
                        intNumb += 1000;
                        break;
                    case 'D':
                        intNumb += 500;
                        break;
                    case 'C':
                        intNumb += 100;
                        if (i > 0)
                            if (stringNumb[i - 1] == 'M' || stringNumb[i - 1] == 'D') intNumb -= 200;
                        break;
                    case 'L':
                        intNumb += 50;
                        break;
                    case 'X':
                        intNumb += 10;
                        if (i > 0)
                            if (stringNumb[i - 1] == 'C' || stringNumb[i - 1] == 'L') intNumb -= 20;
                        break;
                    case 'V':
                        intNumb += 5;
                        break;
                    case 'I':
                        intNumb += 1;
                        if (i > 0)
                            if (stringNumb[i - 1] == 'X' || stringNumb[i - 1] == 'V') intNumb -= 2;
                        break;
                }
            }
            return intNumb;
        }
        public RomanNumberExtend(string stringNumb) : base(ToInt(stringNumb)) { }
    }
}
