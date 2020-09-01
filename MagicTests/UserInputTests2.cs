using System;
using Xunit;
using Magic.Year;

namespace MagicTests
{
    public class UserInputTests2
    {
        UserInput newUserInput = new UserInput();

        [Fact] 
        public void ShouldThrowException_WhenNameIsEmpty(){
            Assert.Throws<Exception>(()=>newUserInput.ThrowExceptionWhenNameIsInvalid("",""));
        }

    }
}