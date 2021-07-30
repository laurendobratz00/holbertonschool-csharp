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
                [Test]
        public void MaxAtBeginning()
        {
            List<int> myList = new List<int>();
            myList.Add(3);
            myList.Add(2);
            myList.Add(1);
            int result = Operations.Max(myList);
            Assert.AreEqual(3, result);
        }
                [Test]
        public void MaxInMiddle()
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(3);
            myList.Add(2);
            int result = Operations.Max(myList);
            Assert.AreEqual(3, result);
        }
                [Test]
        public void Negative()
        {
            List<int> myList = new List<int>();
            myList.Add(-1);
            myList.Add(-2);
            myList.Add(-3);
            int result = Operations.Max(myList);
            Assert.AreEqual(-1, result);
        }
                [Test]
        public void EmptyList()
        {
            List<int> myList = new List<int>();
            int result = Operations.Max(myList);
            Assert.AreEqual(0, result);
        }
    }
}