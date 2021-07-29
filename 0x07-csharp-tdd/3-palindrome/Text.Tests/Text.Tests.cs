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
        public void emptystring()
        {
            Assert.AreEqual(true, Str.IsPalindrome(""));
        }
        [Test]
        public void shortpal()
        {
            Assert.AreEqual(true, Str.IsPalindrome("aba"));
        }
        [Test]
        public void shortnonpal()
        {
            Assert.AreEqual(false, Str.IsPalindrome("abc"));
        }
        [Test]
        public void mixedcasepal()
        {
            Assert.AreEqual(true, Str.IsPalindrome("raceCar"));
        }
        [Test]
        public void punctuation()
        {
            Assert.AreEqual(true, Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }
    }
}
