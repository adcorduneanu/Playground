namespace RomanNumberals.Tests
{
    using NUnit.Framework;

    public class RomanNumeralConverterShould
    {
        private RomanNumeralConverter romanNumberalConverter;
        
        [SetUp]
        public void Initialize()
        {
            romanNumberalConverter = new RomanNumeralConverter();
        }
    }
}
