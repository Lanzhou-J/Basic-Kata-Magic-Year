using Xunit;
using Magic.Year;
namespace MagicTests
{
    public class MagicTestsWorkShould
    {
        private Work _work;
 
        [Fact]
        public void CalculateMonthlySalaryRoundedAmount_ShouldEqual5004_WhenAnnualSalaryIs60050()
        {
            Salary annualSalary = new Salary(60050);
            _work = new Work(2020,annualSalary:annualSalary);
            var result = _work.CalculateMonthlySalary().RoundedAmount;

            Assert.Equal(5004, result);
        }
        
        [Fact]
        public void CalculateMonthlySalaryRoundedAmount_ShouldEqual6482_WhenAnnualSalaryIs77778()
        {
            Salary annualSalary = new Salary(77778);
            _work = new Work(2020,annualSalary:annualSalary);
            var result = _work.CalculateMonthlySalary().RoundedAmount;

            Assert.Equal(6482, result);
        }
        
    }
}