namespace CodeKata
{
    public class AnagramChecker
    {
        public bool CheckAnagram(string word1, string word2)
        {
            var count1 = CreateAnagramDictionary(word1);
            var count2 = CreateAnagramDictionary(word2);
            var keys = count1.Keys.ToList();

            foreach (var key in keys)
            {
                if (count1[key] != count2[key])
                    return false;
            }

            return true;
        }


        private Dictionary<char, int> CreateAnagramDictionary(string word)
        {
            var result = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if (result.TryGetValue(letter, out int count))
                {
                    result[letter] = ++count;
                }
                else
                {
                    result.Add(letter, 1);
                }
            }

            return result;
        }

        public (int count, string anagramWords) FindLongestAnagram(List<string> words)
        {
            Dictionary<Dictionary<char, int>, List<string>> numberOfSameAnagrams = new Dictionary<Dictionary<char, int>, List<string>>();

            foreach (var word in words)
            {
                var dictionary = CreateAnagramDictionary(word);
                if (numberOfSameAnagrams.TryGetValue(dictionary, out List<string> anagramWords))
                {
                    anagramWords.Add(word);
                }
                else
                {
                    numberOfSameAnagrams.Add(dictionary, new List<string> { word });
                }
            }

            var result = numberOfSameAnagrams.Values.ToList().OrderByDescending(x => x.Count).First();

            return (result.Count, string.Join(" ", result));
        }
    }
}
