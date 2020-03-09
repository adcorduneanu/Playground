namespace LeapYear.Tests
{
    using FluentAssertions;
    using NUnit.Framework;

    public class YearShould
    {

        [Test]
        public void Be_Leap_Year_If_Is_Divisible_By_400()
        {
            new Year(1600).IsLeap().Should().BeTrue();
        }

        [Test]
        public void Not_Be_Leap_If_Is_Divisible_By_100_But_Not_By_400()
        {
            new Year(1700).IsLeap().Should().BeFalse();
        }

        [Test]
        public void Be_Leap_Year_If_Is_Divisible_By_4()
        {
            new Year(1604).IsLeap().Should().BeTrue();
        }
    }
}