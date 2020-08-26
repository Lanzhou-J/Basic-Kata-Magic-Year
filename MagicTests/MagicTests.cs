using System;
using Xunit;
using Magic.Year;

namespace MagicTests
{
    public class MagicTests_IsMagicShould
    {
        private readonly MagicYear _magicYear;
        public MagicTests_IsMagicShould() {
            _magicYear = new MagicYear();
        }

        [Fact]
        public void IsMagic_InputIs1_ReturnFalse()
        {
            var result = _magicYear.IsMagic(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}
