using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static partial class Kata
    {
        public static bool Narcissistic(int value)
        {
            var digits = value.ToDigitList();
            var pow = digits.Count;
            return digits.Sum(d => (int)(Math.Pow(d, pow))) == value;
        }
    }
}
