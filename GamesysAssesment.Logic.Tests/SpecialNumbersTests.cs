using System;
using NUnit.Framework;
using Microsoft.FSharp.Collections;

namespace GamesysAssesment.Logic.Tests
{
    [TestFixture]
    public class SpecialNumbersTests
    {
        [Test]
        public void GetNThNumber_ReturnsCorrectNumber()
        {
            var list = ListModule.OfSeq(new[] { 1.0, 2.0, 3.0, 4.0, 5.0 });

            double returnedNumber = SpecialNumbers.getNthLargestNumber(3, list);

            Assert.AreEqual(3.0, returnedNumber);
        }

        [ExpectedException(typeof(ArgumentException))]
        [Test]
        public void GetNThNumber_NegativeIndex_ThrowsException()
        {
            var list = ListModule.OfSeq(new[] { 1.0, 2.0 });

            double number = SpecialNumbers.getNthLargestNumber(-2, list);
        }

        [ExpectedException(typeof(ArgumentException))]
        [Test]
        public void GetNThNumber_ZeroIndex_ThrowsException()
        {
            var list = ListModule.OfSeq(new[] { 1.0, 2.0 });

            double number = SpecialNumbers.getNthLargestNumber(0, list);
        }

        [ExpectedException(typeof(ArgumentException))]
        [Test]
        public void GetNThNumber_IndexHigherThanListLength_ThrowsException()
        {
            var list = ListModule.OfSeq(new[] { 1.0, 2.0 });

            double number = SpecialNumbers.getNthLargestNumber(4, list);
        }

        [TestCase(-100.0, -3.0)]
        [TestCase(-1.5, -1.0)]
        [TestCase(0, -1.0)]
        [TestCase(0.1, 1.0)]
        [TestCase(8.0, 5.0)]
        [TestCase(100.0, 20.0)]
        public void ClosestNumber_FindsClosestNumber(double numberToFind, double expectedClosestNumber)
        {
            var list = ListModule.OfSeq(new[] { -3.0, -1.0, 1.0, 5.0, 20.0 });

            double closestNumber = SpecialNumbers.getClosestNumber(numberToFind, list);

            Assert.AreEqual(expectedClosestNumber, closestNumber);
        }

        [ExpectedException]
        [Test]
        public void ClosestNumber_EmptyList_ThrowsException()
        {
            SpecialNumbers.getClosestNumber(5, FSharpList<double>.Empty);
        }
    }
}
