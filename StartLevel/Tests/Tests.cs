using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StartLevel;

namespace Tests
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void Should_know_basic_level()
        {
            Assert.AreEqual(LowLevel.Sum(1, 1), 2);

            Assert.AreEqual(LowLevel.Multiply(1, 1), 1);

            Assert.AreEqual(LowLevel.Subtraction(1, 1), 0);

            Assert.AreEqual(LowLevel.GetModuleNumber(-1), 1);

            Assert.AreEqual(LowLevel.GetModuleNumber(1), 1);

            Assert.AreEqual(LowLevel.GetRemainderOfDivision(5, 3), 2);

            Assert.AreEqual(LowLevel.GetRemainderOfDivision(10, 2), 0);
        }

        public void TestIndexOf(int[] array, int value, int expect)
        {
            int actual = LowLevel.IndexOf(array, value);
            Assert.AreEqual(expect, actual);
        }
        

        [TestMethod]
        public void Should_be_able_to_find_a_maximal_element()
        {
            Assert.AreEqual(LowLevel.Max(new int[]{1,2,3,4,5}), 5);

            Assert.AreEqual(LowLevel.Max(new int[]{5,4,6,78,4,4,2,1}), 78);
        }

        [TestMethod]
        public void Should_be_able_to_find_a_minimum_element()
        {
            Assert.AreEqual(LowLevel.Min(new int[]{1, 2, 3, 4, 5}), 1);

            Assert.AreEqual(LowLevel.Min(new int[]{5, 4, 6, 78, 4, 4, 2, -1}), -1);
        }

        [TestMethod]
        public void Should_be_able_to_find_a_sum_maximal_and_minimum_element()
        {
            Assert.AreEqual(LowLevel.GetSumMaxAndMinAlemen(new int[] { 1, 2, 3, 4, 5 }), 6);

            Assert.AreEqual(LowLevel.GetSumMaxAndMinAlemen(new int[] { 5, 4, 6, 78, 4, 4, 2, -1 }), 77);
        }

        [TestMethod]
        public void Should_be_able_to_find_a_count_element()
        {
            Assert.AreEqual(LowLevel.CountElements(new int[] { 1, 5, 3, 4, 5 },5), 2);

            Assert.AreEqual(LowLevel.CountElements(new int[] { 5, 4, 6, 78, 4, 4, 2, 1 }, 4), 3);
        }

        [TestMethod]
        public void Should_be_able_to_find_an_element_in_an_array()
        {
            TestIndexOf(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 7, 7);

            TestIndexOf(new int[] { 4, 3, 5, 6, 7, 8 }, 4, 0);

            TestIndexOf(new int[] { 1, 2, 3, 2, 4 }, 2, 1);

            TestIndexOf(new int[] { 6, 5, 4, 6, 7, 8 }, 10, -1);

        }

        [TestMethod]
        public void Should_be_able_to_divide_the_number_of_digits_in_the()
        {

            int[] expect = LowLevel.GetArrayNumbers(177);
            int[] actual = new int[] { 1, 7, 7 };
            Assert.AreEqual(expect, actual);

            expect = LowLevel.GetArrayNumbers(234);
            actual = new int[] { 2, 3, 4 };
            Assert.AreEqual(expect, actual);

            expect = LowLevel.GetArrayNumbers(984);
            actual = new int[] { 9, 8, 4 };
            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        public void Should_be_able_to_find_the_sum_of_the_numbers()
        {
            int expect = LowLevel.GetSum(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(expect, 15);

            expect = LowLevel.GetSum(new int[] { 0, 0, 0, 0, 0, 6 });
            Assert.AreEqual(expect, 6);

            expect = LowLevel.GetSum(new int[] { 0, 1, 0, 3, 0, 6 });
            Assert.AreEqual(expect, 10);

        }

        [TestMethod]
        public void Should_be_able_to_find_the_product_numbers()
        {
            int expect = LowLevel.GetSum(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(expect, 120);

            expect = LowLevel.GetSum(new int[] { 0, 0, 0, 0, 0, 6 });
            Assert.AreEqual(expect, 0);

            expect = LowLevel.GetSum(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 });
            Assert.AreEqual(expect, 1);
        }


        //Middle Level

        //public void ComparisonFunction(int[] array1, int[] array2, int[] expect, Func<int[], int[], int[]> gerResult)
        //{
        //    int[] actual = gerResult(array1, array2);
        //    Array.Sort(actual);
        //    Assert.AreEqual(expect, actual);
        //}

        //[TestMethod]
        //public void Should_be_able_to_find_the_intersection()
        //{

        //    ComparisonFunction(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4, 5 }, new int[] { 2, 3, 4 }, MiddleLevel.GetIntersection);

        //    ComparisonFunction(new int[] { 3, 4, 5, 6 }, new int[] { 4, 5, 6, 7 }, new int[] { 4, 5, 6 }, MiddleLevel.GetIntersection);
        //}

        //[TestMethod]
        //public void Should_be_able_to_find_a_difference()
        //{
        //    ComparisonFunction(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4, 5 }, new int[] { 1, 5 }, MiddleLevel.GetDifference);

        //    ComparisonFunction(new int[] { 3, 4, 5, 6 }, new int[] { 4, 5, 6, 7 }, new int[] { 3, 7 }, MiddleLevel.GetDifference);

        //}

        //[TestMethod]
        //public void Should_be_able_to_find_the_union()
        //{
        //    ComparisonFunction(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }, MiddleLevel.GetUnion);

        //    ComparisonFunction(new int[] { 3, 4, 5, 6 }, new int[] { 4, 5, 6, 7 }, new int[] { 3, 4, 5, 6, 7 }, MiddleLevel.GetUnion);
        //}

        //[TestMethod]
        //public void Should_be_able_to_connect_two_of_the_array()
        //{
        //    int[] expect = new int[] { 1, 2, 3 };
        //    int[] actual = LowLevel.Contact(new int[] { 1 }, new int[] { 2, 3 });
        //    Assert.AreEqual(expect, actual);


        //    expect = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        //    actual = LowLevel.Contact(new int[] { 9, 8, 7, 6, 5 }, new int[] { 4, 3, 2, 1 });
        //    Assert.AreEqual(expect, actual);

        //}


    }
}
