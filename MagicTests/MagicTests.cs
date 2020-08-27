using Xunit;
using Magic.Year;

namespace MagicTests
{
    public class MagicTestsUserShould
    {
        private readonly User _user;
        public MagicTestsUserShould()
        {
            _user = new User("John","Doe",2020);
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
        public void SetNameValueLan_EqualLan()
        {
            _user.Name = "Lan";

            Assert.Equal("Lan", _user.Name);
        }

        [Fact]
        public void SetSurnameValueJiang_EqualJiang()
        {
            _user.Surname = "Jiang";

            Assert.Equal("Jiang", _user.Surname);
        }

        [Fact]
        public void SetWorkStartYearValue2018_Equal2018()
        {
            _user.WorkStartYear = 2018;

            Assert.Equal(2018, _user.WorkStartYear);
        }
    }
}
