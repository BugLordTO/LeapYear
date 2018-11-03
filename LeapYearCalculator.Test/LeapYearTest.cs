using FluentAssertions;
using System;
using Xunit;

namespace LeapYearCalculator.Test
{
    public class LeapYearTest
    {
        [Fact]
        public void InputYear1ShouldNotBeLeapYear()
        {
            var sut = new LeapYear();
            var actual = sut.Calculate(1);
            actual.Should().BeFalse();
        }

        [Fact]
        public void InputYear4ShouldBeLeapYear()
        {
            var sut = new LeapYear();
            var actual = sut.Calculate(4);
            actual.Should().BeTrue();
        }

        [Fact]
        public void InputYear100ShouldNotBeLeapYear()
        {
            var sut = new LeapYear();
            var actual = sut.Calculate(4);
            actual.Should().BeFalse();
        }
    }
}
