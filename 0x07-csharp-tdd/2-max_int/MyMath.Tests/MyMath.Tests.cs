using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Test cases for 2-max_int</summary>
    public class Tests
    {
        [Test]
        public void MaxAtEnd()
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            int result = Operations.Max(myList);
            Assert.AreEqual(3, result);
        }
    }
}