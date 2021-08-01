using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    /// <summary>Test cases for 2-max_int</summary>
    public class Tests
    {
        [Test]
        public void MaxInt()
        {
            string s = "A man, a plan, a canal: Panama.";
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(true, result);
        }
                [Test]
        public void Empty()
        {
            string s = "";
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(true, result);
        }
    }
}