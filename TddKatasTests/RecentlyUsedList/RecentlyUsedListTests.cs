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

    }
}
