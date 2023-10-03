using CodeKata;

namespace CodeKatasTests.cs.Anagrams
{
    public class AnagramTest
    {
        [Theory]
        [InlineData("listen", "silent", true)]
        [InlineData("test", "stet", true)]
        [InlineData("test", "sets", false)]
        public void CheckAnagrams(string word1, string word2, bool expected)
        {
            var anagramChecker = new AnagramChecker();
            var actual = anagramChecker.CheckAnagram(word1, word2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckLongestAnagram()
        {
            var list = new List<string> {
            "crepitus", "cuprites",  "pictures" ,"piecrust",
            "paste", "pates" ,"peats" ,"septa" ,"spate", "tapes", "tepas",
            "punctilio", "unpolitic",
            "sunders", "undress"
            };
            var anagramChecker = new AnagramChecker();

            var expectedString = "paste pates peats septa spate tapes tepas";
            var expectedCount = 7;
            var result = anagramChecker.FindLongestAnagram(list);

            Assert.Equal(expectedCount, result.count);
            Assert.Equal(expectedString, result.anagramWords);
        }
    }
}