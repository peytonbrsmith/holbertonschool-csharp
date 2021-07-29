using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void normalstring()
        {
            Assert.AreEqual(Str.UniqueChar("helloworld"), 0);
        }
        [Test]
        public void emptystring()
        {
            Assert.AreEqual(Str.UniqueChar(""), -1);
        }
        [Test]
        public void startofstring()
        {
            Assert.AreEqual(Str.UniqueChar("abbbbbbbb"), 0);
        }
        [Test]
        public void endofstring()
        {
            Assert.AreEqual(Str.UniqueChar("bbbbbbbba"), 7);
        }
    }
}
