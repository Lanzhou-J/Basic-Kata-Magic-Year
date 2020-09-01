using Xunit;
using Magic.Year;
namespace MagicTests
{
    public class MagicTestsWorkShould
    {
        private readonly Work _work;
        public MagicTestsWorkShould()
        {
            Salary annualSalary = new Salary(60050);
            _work = new Work(2020,annualSalary:annualSalary);
        }
        [Fact]
        public void CalculateMonthlySalaryRoundedAmount_Equal5004()
        {
            var result = _work.CalculateMonthlySalary().RoundedAmount;

            Assert.Equal(5004, result);
        }
        
    }
}