using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codewars;
using NUnit.Framework;

namespace CodewarsTests
{
    [TestFixture]
    public partial class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("TestCase", "test case".CamelCase());
            Assert.AreEqual("CamelCaseMethod", "camel case method".CamelCase());
            Assert.AreEqual("SayHello", "say hello".CamelCase());
            Assert.AreEqual("CamelCaseWord", " camel case word".CamelCase());
            Assert.AreEqual("KuRlXjzyjHcylrddfJ", "ku rl xjzyj hcylrddf j".CamelCase());
            Assert.AreEqual("", "".CamelCase());
        }

        //[Test]
        //public void SampleTest()
        //{
        //    Assert.AreEqual(new int[] { 2 }, Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
        //    Assert.AreEqual(new int[] { 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
        //    Assert.AreEqual(new int[] { 1 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
        //    Assert.AreEqual(new int[] { 1, 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
        //    Assert.AreEqual(new int[] { }, Kata.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
        //}

        //private static IEnumerable<TestCaseData> sampleTestCases
        //{
        //    get
        //    {
        //        yield return new TestCaseData(0).Returns(false);
        //        yield return new TestCaseData(1).Returns(false);
        //        yield return new TestCaseData(2).Returns(true);
        //    }
        //}

        //[Test, TestCaseSource("sampleTestCases")]
        //public bool SampleTest(int n) => Kata.IsPrime(n);

        //[Test]
        //[TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        //[TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
        //public static string FixedTest(int[] numbers)
        //{
        //    return Kata.CreatePhoneNumber(numbers);
        //}

        //[Test]
        //public void Example()
        //{
        //    Assert.AreEqual(Kata.ReverseWords("This is an example!"), "sihT si na !elpmaxe");
        //}


        //[Test]
        //[TestCase(451999277, 41177722899, ExpectedResult = 1)]
        //[TestCase(1222345, 12345, ExpectedResult = 0)]
        //[TestCase(12345, 12345, ExpectedResult = 0)]
        //[TestCase(666789, 12345667, ExpectedResult = 1)]
        //[TestCase(10560002, 100, ExpectedResult = 1)]
        //public static int FixedTest(long s1, long s2)
        //{
        //    return Kata.TripleDouble(s1, s2);
        //}

        //[Test, Description("Sample Tests")]
        //public void Test()
        //{
        //    Assert.AreEqual("128.114.17.104", Kata.UInt32ToIP(2154959208));
        //    Assert.AreEqual("0.0.0.0", Kata.UInt32ToIP(0));
        //    Assert.AreEqual("128.32.10.1", Kata.UInt32ToIP(2149583361));
        //}

        //[Test]
        //public void BasicTests()
        //{
        //    //var kata = new Kata();

        //    Assert.AreEqual(0, Kata.NumberOfCarries(543, 3456));

        //    Assert.AreEqual(2, Kata.NumberOfCarries(1927, 6426));

        //    Assert.AreEqual(4, Kata.NumberOfCarries(9999, 1));

        //    Assert.AreEqual(2, Kata.NumberOfCarries(1234, 5678));

        //}

        //[Test]
        //[TestCase(155, ExpectedResult = -1)]
        //[TestCase(121, ExpectedResult = 144)]
        //[TestCase(625, ExpectedResult = 676)]
        //[TestCase(319225, ExpectedResult = 320356)]
        //[TestCase(15241383936, ExpectedResult = 15241630849)]
        //public static long FixedTest(long num)
        //{
        //    return Kata.FindNextSquare(num);
        //}

        //[Test]
        //public void HighAndLowTest()
        //{
        //    Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        //}

        //[Test]
        //public void GetIntegersFromList_MixedValues_ShouldPass_1()
        //{
        //    var list = new List<object>() { 1, 2, "a", "b" };
        //    var expected = new List<int>() { 1, 2 };
        //    var actual = ListFilterer.GetIntegersFromList(list);
        //    Assert.IsTrue(expected.SequenceEqual(actual));
        //}
        //[Test]
        //public void GetIntegersFromList_MixedValues_ShouldPass_2()
        //{
        //    var list = new List<object>() { 1, "a", "b", 0, 15 };
        //    var expected = new List<int>() { 1, 0, 15 };
        //    var actual = ListFilterer.GetIntegersFromList(list);
        //    Assert.IsTrue(expected.SequenceEqual(actual));
        //}
        //[Test]
        //public void GetIntegersFromList_MixedValues_ShouldPass_3()
        //{
        //    var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
        //    var expected = new List<int>() { 1, 2, 123 };
        //    var actual = ListFilterer.GetIntegersFromList(list);
        //    Assert.IsTrue(expected.SequenceEqual(actual));
        //}

        //[Test]
        //public void CountPositivesSumNegatives_BasicTest()
        //{
        //    int[] expectedResult = new int[] { 10, -65 };

        //    Assert.AreEqual(expectedResult, Kata.CountPositivesSumNegatives(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 }));
        //}

        //[Test]
        //public void CountPositivesSumNegatives_InputWithZeroes()
        //{
        //    int[] expectedResult = new int[] { 8, -50 };

        //    Assert.AreEqual(expectedResult, Kata.CountPositivesSumNegatives(new[] { 0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14 }));
        //}

        //[Test, Description("ValidatePin should return false for pins with length other than 4 or 6")]
        //public void LengthTest()
        //{
        //    Assert.AreEqual(false, Kata.ValidatePin("1"), "Wrong output for \"1\"");
        //    Assert.AreEqual(false, Kata.ValidatePin("12"), "Wrong output for \"12\"");
        //    Assert.AreEqual(false, Kata.ValidatePin("123"), "Wrong output for \"123\"");
        //    Assert.AreEqual(false, Kata.ValidatePin("12345"), "Wrong output for \"12345\"");
        //    Assert.AreEqual(false, Kata.ValidatePin("1234567"), "Wrong output for \"1234567\"");
        //    Assert.AreEqual(false, Kata.ValidatePin("-1234"), "Wrong output for \"-1234\"");
        //    Assert.AreEqual(false, Kata.ValidatePin("1.234"), "Wrong output for \"1.234\"");
        //    Assert.AreEqual(false, Kata.ValidatePin("00000000"), "Wrong output for \"00000000\"");
        //}

        //[Test, Description("ValidatePin should return false for pins which contain characters other than digits")]
        //public void NonDigitTest()
        //{
        //    Assert.AreEqual(false, Kata.ValidatePin("a234"), "Wrong output for \"a234\"");
        //    Assert.AreEqual(false, Kata.ValidatePin(".234"), "Wrong output for \".234\"");
        //}

        //[Test, Description("ValidatePin should return true for valid pins")]
        //public void ValidTest()
        //{
        //    Assert.AreEqual(true, Kata.ValidatePin("1234"), "Wrong output for \"1234\"");
        //    Assert.AreEqual(true, Kata.ValidatePin("0000"), "Wrong output for \"0000\"");
        //    Assert.AreEqual(true, Kata.ValidatePin("1111"), "Wrong output for \"1111\"");
        //    Assert.AreEqual(true, Kata.ValidatePin("123456"), "Wrong output for \"123456\"");
        //    Assert.AreEqual(true, Kata.ValidatePin("098765"), "Wrong output for \"098765\"");
        //    Assert.AreEqual(true, Kata.ValidatePin("000000"), "Wrong output for \"000000\"");
        //    Assert.AreEqual(true, Kata.ValidatePin("090909"), "Wrong output for \"090909\"");
        //}

        //[Test]
        //public void DupeCountKataTests()
        //{
        //    Assert.AreEqual(0, Kata.DuplicateCount(""));
        //    Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
        //    Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
        //    Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
        //    Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
        //    Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        //}

        //[Test]
        //public void Test1()
        //{
        //    Assert.AreEqual(1, DigPow.digPow(89, 1));
        //}
        //[Test]
        //public void Test2()
        //{
        //    Assert.AreEqual(-1, DigPow.digPow(92, 1));
        //}
        //[Test]
        //public void Test3()
        //{
        //    Assert.AreEqual(51, DigPow.digPow(46288, 3));
        //}

    }
}
