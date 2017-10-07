using System;
using System.Linq;

namespace Codewars
{
    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            var chars = n.ToString().ToList();
            var nums = chars.ConvertAll(c => (long)Char.GetNumericValue(c));

            long dumbsum = 0;
            foreach (var number in nums)
            {
                dumbsum += (long)Math.Pow(number, p++);

            }

            long k = 0;
            long testSum = 0;
            while (testSum < dumbsum)
            {
                testSum = n * k;
                if (dumbsum == testSum)
                {
                    return k;
                }
                k++;
            }
            return -1;
        }
    }
}