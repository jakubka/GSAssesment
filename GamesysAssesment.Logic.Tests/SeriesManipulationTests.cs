using System;
using NUnit.Framework;

namespace GamesysAssesment.Logic.Tests
{
    [TestFixture]
    public class SeriesManipulationTests
    {
        [TestCase(0, 0)] // zero stays zero
        [TestCase(0.1, 0)] // from 0.1 to 1:
        [TestCase(0.125, 0.25)]
        [TestCase(0.2, 0.25)]
        [TestCase(0.3, 0.25)]
        [TestCase(0.4, 0.5)]
        [TestCase(0.5, 0.5)]
        [TestCase(0.6, 0.5)]
        [TestCase(0.7, 0.75)]
        [TestCase(0.8, 0.75)]
        [TestCase(0.9, 1.0)]
        [TestCase(1.0, 1.0)]
        [TestCase(-1.1, -1)] // negative numbers:
        [TestCase(-1.2, -1.25)]
        [TestCase(-1.3, -1.25)]
        [TestCase(-1.4, -1.5)]
        [TestCase(-1.5, -1.5)]
        [TestCase(123153425.653, 123153425.75)] // big numbers
        [TestCase(133245.8123, 133245.75)] // big numbers
        public void RoundToQuarter_RoundsCorrectly(double input, double expectedRounded)
        {
            var rounded = SeriesManipulation.roundToQuarter(input);

            Assert.AreEqual(expectedRounded, rounded);
        }
    }
}
