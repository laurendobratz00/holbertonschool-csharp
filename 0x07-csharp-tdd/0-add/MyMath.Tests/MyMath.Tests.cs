using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Test cases for 0-add</summary>
    public class Tests
    {
        [Test]
        public void AddTest()
        {
            var result = Operations.Add(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}