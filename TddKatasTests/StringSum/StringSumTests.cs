using TddKatas;

namespace TddKatasTests
{
    public class StringSumTests
    {
        [Fact]
        public void ShouldSum2Numbers() 
        {
            var sumCalculator = new SumCalculator();
            var result = sumCalculator.Sum("1","5");

            Assert.Equal("6", result);
        }

        [Fact]
        public void ShouldRemoveAllNonNumberCharacters() 
        {
            var sumCalculator = new SumCalculator();
            var result = sumCalculator.Sum("121fdaffdasfasddfas", "1dfasfdasfdasfadsfafdasfdasfasd/'/'/'/'/';;';'p[");

            Assert.Equal("122", result);
        }
    }
}
