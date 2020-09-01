using Magic.Year;
using Xunit;

namespace MagicTests
{
    public class MagicTestsCalculatorShould
    {
        private readonly Calculator _calculator;
        
        public MagicTestsCalculatorShould()
        {
            
            _calculator = new Calculator();
        }
        
        [Fact]
        public void CalculateMagicYear_Input2020_Equal2085()
        {
            var startYear = 2020;
            var result = _calculator.CalculateMagicYear(startYear:startYear);

            Assert.Equal(2085, result);
        }
        
        [Fact]
        public void CalculateMagicYear_Input1980_Equal2045()
        {
            var startYear = 1980;
            var result = _calculator.CalculateMagicYear(startYear:startYear);

            Assert.Equal(2045, result);
        }
        
    }
}