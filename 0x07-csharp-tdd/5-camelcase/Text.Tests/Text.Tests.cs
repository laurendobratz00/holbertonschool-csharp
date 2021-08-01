using NUnit.Framework;
using System;

namespace Text.Tests
{
    [TestFixture]
    /// <summary>Test cases for 4-unique</summary>
    public class Tests
    {
        [Test]
        public void Empty()
        {
            string s = "";
            int result = Str.CamelCase(s);
            Assert.AreEqual(result, 0);
        }
        [Test]
        public void OneWord()
        {
            string s = "nugget";
            int result = Str.CamelCase(s);
            Assert.AreEqual(result, 1);
        }
        [Test]
        public void TwoWords()
        {
            string s = "nugget Love";
            int result = Str.CamelCase(s);
            Assert.AreEqual(result, 2);
        }
        [Test]
        public void LotsOfWords()
        {
            string s = "nugget Is The Goodest Gurl";
            int result = Str.CamelCase(s);
            Assert.AreEqual(result, 5);
        }
    }
}