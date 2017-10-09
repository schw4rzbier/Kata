using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static partial class Kata
    {
        public static string CamelCase(this string str)
        {
            if (String.IsNullOrWhiteSpace(str)) return "";

            var tstr = str.Trim();

            var words = tstr.Split(' ');
            var rtnStr = "";
            foreach (var word in words)
            {
                var tmp = word.ToList();
                tmp[0] = Char.ToUpper(tmp[0]);
                rtnStr += string.Concat(tmp);
            }
            return rtnStr;
        }
    }
}
