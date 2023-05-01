using TddKatas;

namespace TddKatasTests
{
    public class RecentlyUsedListTests
    {
        [Fact(DisplayName = "Firstly added item should be added on first position, lastly added item should be last")]
        public void Test()
        {
            var list = new RecentlyUsedList();
            list.Add("Test1");
            list.Add("Test2");
            list.Add("Test3");

            var result = list.getByIndex(0);
            var result2 = list.getByIndex(1);

            Assert.Equal("Test3", result);
            Assert.Equal("Test2", result2);
        }

        [Fact(DisplayName = "Duplicates are moved rather than duplicated")]
        public void Test2()
        {
            var list = new RecentlyUsedList();
            list.Add("Test1");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("Test4");
            list.Add("Test1");
            list.Add("Test3");
            list.Add("Test4");
            list.Add("Test2");
            list.Add("Test1");


            var result = list.getByIndex(0);
            var result2 = list.getByIndex(1);
            var result3 = list.getByIndex(2);
            var result4 = list.getByIndex(3);

            Assert.Equal("Test1", result);
            Assert.Equal("Test2", result2);
            Assert.Equal("Test4", result3);
            Assert.Equal("Test3", result4);
            Assert.Equal(4, list.Length);
        }

        [Fact(DisplayName = "Null insertions are not allowed")]
        public void NullInsertionsNotAllowed()
        {
            var list = new RecentlyUsedList();
            list.Add("Test1");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("");
            list.Add("");
            list.Add("");
            list.Add("");

            var result = list.Length;
            Assert.Equal(3, result);
        }

        [Fact(DisplayName = "Add initial capacity, overflow items are disregarded")]
        public void DisregardOverflowItems() 
        {
            var list = new RecentlyUsedList(2);
            list.Add("Test1");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("Test4");
            list.Add("Test5");
            list.Add("Test6");
            list.Add("Test2");
            list.Add("Test3");

            var result1 = list.getByIndex(0);
            var result2 = list.getByIndex(1);
            Assert.Equal("Test3", result1);
            Assert.Equal("Test2", result2);
            Assert.Equal(2, list.Length);
        }

        [Fact(DisplayName = "Should throw an exception Negative values not allowed when getting an element by negative index")]
        public void ShouldThrowExceptionWhenGettingByNegativeIndex() 
        {
            var list = new RecentlyUsedList(2);
            list.Add("Test1");
            list.Add("Test2");

            Assert.Throws<Exception>(() => list.getByIndex(-1));
        }
    }
}
