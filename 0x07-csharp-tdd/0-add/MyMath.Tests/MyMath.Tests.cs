using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSmallPositives()
        {
            var result = Operations.Add(1, 2);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void TestSmallNegatives()
        {
            var result = Operations.Add(-1, -2);
            Assert.AreEqual(-3, result);
        }
        [TestCase(-62, 300)]
        public void TestLargeMixedSign(int a, int b)
        {
            var result = Operations.Add(a, b);
            Assert.AreEqual(238, result);
        }
    }
}
