using Xunit;
using Magic.Year;

namespace MagicTests
{
    public class MagicTestsUserShould
    {
        private readonly User _user;
        private readonly Salary _salary;
        public MagicTestsUserShould()
        {
            _salary = new Salary(amount:60050);
            _user = new User("John","Doe",2020, _salary);
        }

        [Fact]
        public void GetName_EqualJohn()
        {
            var result = _user.Name;

            Assert.Equal("John", result);
        }

        [Fact]
        public void GetSurName_EqualDoe()
        {
            var result = _user.Surname;

            Assert.Equal("Doe", result);
        }

        [Fact]
        public void GetWorkStartYear_Equal2020()
        {
            var result = _user.WorkStartYear;

            Assert.Equal(2020, result);
        }
        
        [Fact]
        public void GetAnnualSalary_Equal_salary()
        {
            var result = _user.AnnualSalary;

            Assert.Equal(_salary, result);
        }
    }
}
