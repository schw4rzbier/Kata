using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static partial class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            //return a.Except(b).ToArray();
            return a.Where(x => !b.Contains(x)).ToArray();
        }
    }
}
