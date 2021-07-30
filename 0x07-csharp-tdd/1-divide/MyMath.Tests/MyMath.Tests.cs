using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Test cases for 1-divide</summary>
    public class Tests
    {
        [Test]
        public void AddTest()
        {
            int[,] myMatrix = new int[,]
            {
                {2, 4, 6},
                {8, 10, 12}
            };
            var result = Matrix.Divide(myMatrix, 2);
            int[,] otherMatrix = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6}
            };
            Assert.AreEqual(myMatrix, otherMatrix);
        }
    }
}