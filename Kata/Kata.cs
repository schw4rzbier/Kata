using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    public static partial class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            string pNum = "";
            numbers.ToList()
                    .ForEach(num =>
                    {
                        pNum += num.ToString();
                    });
            return $"({pNum.Substring(0,3)}) {pNum.Substring(3,3)}-{pNum.Substring(6, 4)}";
        } 

        public static string ReverseWords(string str)
        {
            var strList = str.Split(' ');
            var sb = new StringBuilder();
            foreach (var s in strList)
            {
                var reversedList = s.Reverse();
                
                foreach (var c in reversedList)
                {
                    sb.Append(c);
                }
                sb.Append(' ');
            }
            var rtnstr = sb.ToString();
            return rtnstr.TrimEnd();
        }

        public static List<int> ToDigitList(this int num)
        {
            return ((long) num).ToDigitList();
        }

        public static List<int> ToDigitList(this long num)
        {
            return num.ToString().ToList().ConvertAll(c => (int)Char.GetNumericValue(c));
        }

        public static bool HasDouble(List<int> digits, int testDigit)
        {
            for (int i = 0; i <= digits.Count - 2; i++)
            {
                if ((digits[i] == testDigit) && (digits[i] == digits[i + 1]))
                {
                    return true;
                }
                
            }
            return false;
        }

        public static int TripleDouble(long num1, long num2)
        {
            var num1Digits = num1.ToDigitList();
            var num2Digits = num2.ToDigitList();

            for (int i = 0; i <= num1Digits.Count - 3; i++)
            {
                if ((num1Digits[i] == num1Digits[i + 1]) && (num1Digits[i] == num1Digits[i + 2]))
                {
                    if (HasDouble(num2Digits, num1Digits[i]))
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        public static string UInt32ToIP(UInt32 ip)
        {
            var byte0 = ip & 0xff;
            var byte1 = (ip & 0xff00) >> 8;
            var byte2 = (ip & 0xff0000) >> 16;
            var byte3 = (ip & 0xff000000) >> 24;

            return byte3 + "." + byte2 + "." + byte1 + "." + byte0;
        }

        public static List<int> chopNum(int num)
        {
            var chars = num.ToString().ToList();
            chars.Reverse();
            return chars.ConvertAll(c => (int)Char.GetNumericValue(c));
        }

        public static int NumberOfCarries(int a, int b)
        {
            var aList = chopNum(a);
            var bList = chopNum(b);

            return 1;
        }

        public static int DuplicateCount(string str)
        {
            int rtnCnt = 0;
            var strLst = str.ToLower().ToList();
            while(strLst.Any())
            {
                var ch = strLst.First();
                if (strLst.Count(c => c == ch) > 1)
                {
                    rtnCnt++;
                }
                strLst.RemoveAll(c => c == ch);
            }
            return rtnCnt;
        }


        public static bool ValidatePin(string pin)
        {
            int number;
            return Int32.TryParse(pin, out number) && (number >= 0) &&
                (new List<int>{4, 6}).Contains(pin.Length);
            
        }

        public static bool IsPerfectSquare(long num)
        {
            var sqrtNum = Math.Sqrt(num);
            var diff = sqrtNum - Math.Truncate(sqrtNum);

            if (diff == 0) return true;
            return false;

        }

        public static long FindNextSquare(long num)
        {
            if (!IsPerfectSquare(num)) return -1;

            while (true)
            {
                if (IsPerfectSquare(++num)) return num;
            }

        }

        public static string HighAndLow(string numbers)
        {
            var strList = numbers.Split(' ').ToList();

            var numList = strList.ConvertAll(n => Convert.ToInt32(n));

            numList.Sort();

            return numList[numList.Count - 1] + " " + numList[0];
        }

        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0) return new int[] { };
            return new []
            {
                input.Count(i => i > 0),
                input.Where(i => i < 0).Sum()
            }; //return an array with count of positives and sum of negatives
        }

    }

    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            var rtnList = new List<int>();

            foreach (var obj in listOfItems)
            {
                if(obj is int) { rtnList.Add((int)obj); }
            }

            return rtnList;

        }
    }
}
