using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SmallPositives()
        {
            int [,] test_matrix = new int [2,4] {
                {2, 4, 6, 8} ,
                {10, 12, 14, 16}
            };
            int [,] expected = new int [2,4] {
                {1, 2, 3, 4} ,
                {5, 6, 7, 8}
            };
            var result = Matrix.Divide(test_matrix, 2);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void SmallNegatives()
        {
            int [,] test_matrix = new int [2,4] {
                {-2, -4, -6, -8} ,
                {-10, -12, -14, -16}
            };
            int [,] expected = new int [2,4] {
                {-1, -2, -3, -4} ,
                {-5, -6, -7, -8}
            };
            var result = Matrix.Divide(test_matrix, 2);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void Zeroes()
        {
            int [,] test_matrix = new int [2,4] {
            {-2, -4, -6, -8} ,
            {-10, -12, -14, -16}
            };
            var result = Matrix.Divide(test_matrix, 0);
            Assert.AreEqual(result, null);
        }
        [Test]
        public void isnull()
        {
            var result = Matrix.Divide(null, 0);
            Assert.AreEqual(result, null);
        }
    }
}
