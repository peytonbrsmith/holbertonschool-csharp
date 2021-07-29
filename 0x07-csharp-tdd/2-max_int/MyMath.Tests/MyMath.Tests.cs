using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ForwardPositives()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = Operations.Max(list);

            Assert.AreEqual(10, result);
        }
        [Test]
        public void MidMax()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 11, 6, 7, 8, 9, 10 };
            var result = Operations.Max(list);

            Assert.AreEqual(11, result);
        }
        [Test]
        public void EmptyList()
        {
            List<int> list = new List<int>() {};
            var result = Operations.Max(list);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void BackwardsPositives()
        {
            List<int> list = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var result = Operations.Max(list);

            Assert.AreEqual(10, result);
        }

        [Test]
        public void ForwardsNegatives()
        {
            List<int> list = new List<int>() { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
            var result = Operations.Max(list);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void BackwardsNegatives()
        {
            List<int> list = new List<int>() { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1 };
            var result = Operations.Max(list);

            Assert.AreEqual(-1, result);
        }
    }
}
