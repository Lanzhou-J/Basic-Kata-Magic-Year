using Xunit;
using Magic.Year;

namespace MagicTests
{
    public class MagicTestsUserShould
    {
        private readonly User _user;
        
        public MagicTestsUserShould()
        {
            
            _user = new User("John","Doe");
        }

        [Fact]
        public void FormatFullname_EqualJohnDoe()
        {
            var result = _user.FormatFullname();

            Assert.Equal("John Doe", result);
        }
        
    }
}
