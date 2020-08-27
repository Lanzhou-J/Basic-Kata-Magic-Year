using Xunit;
using Magic.Year;

namespace MagicTests
{
    public class MagicTestsUserShould
    {
        private readonly User _user;
        private readonly Salary _salary;
        private readonly Work _work;
        public MagicTestsUserShould()
        {
            _salary = new Salary(amount:60050);
            _work = new Work(startYear:2020, annualSalary:_salary);
            _user = new User("John","Doe", work:_work);
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
        public void GetFullName_EqualJohnDoe()
        {
            var result = _user.Fullname;
            Assert.Equal("John Doe", result);
        }
    }
}
