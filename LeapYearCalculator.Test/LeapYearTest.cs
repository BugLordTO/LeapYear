using FluentAssertions;
using System;
using Xunit;

namespace LeapYearCalculator.Test
{
    public class LeapYearTest
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(4, true)]
        [InlineData(100, false)]
        [InlineData(1600, true)]
        [InlineData(1700, false)]
        [InlineData(1800, false)]
        [InlineData(1900, false)]
        [InlineData(2000, true)]
        [InlineData(2008, true)]
        [InlineData(2012, true)]
        [InlineData(2016, true)]
        [InlineData(2017, false)]
        [InlineData(2018, false)]
        [InlineData(2019, false)]
        [InlineData(2100, false)]
        public void LeapYearCalculatorTest(int n, bool expected)
        {
            var sut = new LeapYear();
            var actual = sut.Calculate(n);
            actual.Should().Be(expected);
        }
    }
}
