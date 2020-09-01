using System;
using Xunit;
using Magic.Year;

namespace MagicTests
{
    public class UserTests
    {
        private readonly User _user;
        
        [Fact]
        public void GetFullname_ShouldReturnFullname_WhenHavingFirstNameAndSurname()
        {
            User _user = new User("John", "Doe");
            var result = _user.GetFullname();

            Assert.Equal("John Doe", result);
        }
        
        [Fact]
        public void GetFullname_ShouldReturnNewFullname_WhenHavingFirstNameAndSurname()
        {
            User _user = new User("Lanzhou", "Jiang");
            var result = _user.GetFullname();

            Assert.Equal("Lanzhou Jiang", result);
        }

    }
}
