using FluentAssertions;
using System;
using Xunit;

namespace LeapYearCalculator.Test
{
    public class LeapYearTest
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, false)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(6, false)]
        [InlineData(7, false)]
        [InlineData(8, true)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        [InlineData(20, true)]
        [InlineData(18, false)]
        [InlineData(99, false)]
        [InlineData(100, false)]
        [InlineData(200, false)]
        [InlineData(300, false)]
        [InlineData(430, false)]
        [InlineData(420, true)]
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
        public void LeapYearCalculatorTest(int year, bool expected)
        {
            var sut = new LeapYear();
            var actual = sut.Calculate(year);
            actual.Should().Be(expected);
        }
    }
}
