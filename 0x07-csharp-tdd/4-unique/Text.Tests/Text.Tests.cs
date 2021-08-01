using NUnit.Framework;
using System;

namespace Text.Tests
{
    [TestFixture]
    /// <summary>Test cases for 4-unique</summary>
    public class Tests
    {
        [Test]
        public void Middle()
        {
            string s = "mmmmmmmpmm";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, 7);
        }
                [Test]
        public void Beginning()
        {
            string s = "pmmmmmmmmm";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, 0);
        }
                [Test]
        public void End()
        {
            string s = "mmmmmmmmmp";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, 9);
        }
                [Test]
        public void Empty()
        {
            string s = "";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, -1);
        }
                [Test]
        public void None()
        {
            string s = "mmmmmmmmmm";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, -1);
        }
    }
}