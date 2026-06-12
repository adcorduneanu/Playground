namespace RomanNumberals.Tests
{
    using Shouldly;
    using Xunit;

    public class RomanNumeralConverterShould
    {
        private readonly RomanNumeralConverter romanNumberalConverter;

        public RomanNumeralConverterShould()
        {
            romanNumberalConverter = new RomanNumeralConverter();
        }
    }
}
