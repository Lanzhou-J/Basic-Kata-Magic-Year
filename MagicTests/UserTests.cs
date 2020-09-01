using Xunit;
using Magic.Year;

namespace MagicTests
{
    public class UserTests
    {
        private readonly User _user;
        
        [Fact]
        public void FormatFullname_ShouldReturnFullname_WhenHavingFirstNameAndSurname()
        {
            //should instantiate a new user here
            var result = _user.FormatFullname();

            Assert.Equal("John Doe", result);
        }
        
        //if name null -> throw exception
        
    }
}
