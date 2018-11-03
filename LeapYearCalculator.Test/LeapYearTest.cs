using FluentAssertions;
using System;
using Xunit;

namespace LeapYearCalculator.Test
{
    public class LeapYearTest
    {
        [Theory]
        [InlineData(1,false)]
        [InlineData(2017, false)]
        [InlineData(2019, false)]
        [InlineData(4, true)]
        [InlineData(100, false)]
        [InlineData(1600, true)]
        public void LeapYearCalculatorTest(int n,bool expected)
        {
            var sut = new LeapYear();
            var actual = sut.Calculate(n);
            actual.Should().Be(expected);
        }
    }
}
