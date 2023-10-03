namespace CodeKatasTests.cs
{
    public class Palindrome
    {
        [Theory(DisplayName = "Should test number digits")]
        [InlineData(12345, 5)]
        [InlineData(1, 1)]
        [InlineData(111111111, 9)]
        [InlineData(123, 3)]
        [InlineData(1342456, 7)]
        public void ShouldTestNumberDigits(int number, int expected)
        {
            var actual = new CodeKata.Palindrome().NumDigits(number);

            Assert.Equal(expected, actual);
        }

        [Theory(DisplayName = "Should test palindrome")]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(-1, false)]
        [InlineData(1000021, false)]
        [InlineData(9999, true)]
        public void ShouldTestPalindrome(int number, bool expected)
        { 
            var actual = new CodeKata.Palindrome().IsPalindrome(number);
            Assert.Equal(expected, actual);
        }
    }
}
