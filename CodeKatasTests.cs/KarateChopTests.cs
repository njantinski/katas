using CodeKata;

namespace CodeKatasTests.cs
{
    public class KarateChopTests
    {
        [Fact(DisplayName = "Binary search iterative tests")]
        public void BinarySearchIterativeTest()
        {
            var array = new int[] { 1, 10, 15, 16, 17, 25, 40, 45, 60, 80, 120, 1000, 10000, 13000, 13554, 20000 };
            var number = 13000;

            var expected = 13;
            var binarySearch = new KarateChop();
            Assert.Equal(expected, binarySearch.BinarySearchIterative(array, number));
        }    
        
        [Fact(DisplayName = "Binary search recursively tests")]
        public void BinarySearchRecursively()
        {
            var array = new int[] { 1, 10, 15, 16, 17, 25, 40, 45, 60, 80, 120, 1000, 10000, 13000, 13554, 20000 };
            var number = 13000;

            var expected = 13;
            var binarySearch = new KarateChop();
            Assert.Equal(expected, binarySearch.BinarySearchRecursion(array, number, 0, array.Length));
        }
    }
}