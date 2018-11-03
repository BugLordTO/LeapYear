using FluentAssertions;
using System;
using Xunit;

namespace LeapYearCalculator.Test
{
    public class LeapYearTest
    {
        [Fact]
        public void Test1()
        {
            var sut = new LeapYear();
            var actual = sut.Calculate(1);
            actual.Should().BeFalse();
        }
    }
}
