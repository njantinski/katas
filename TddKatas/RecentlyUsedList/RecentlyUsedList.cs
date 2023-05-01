namespace TddKatas
{
    public class RecentlyUsedList
    {
        private int _counter;

        public RecentlyUsedList()
        {
            Items = new List<string>();
            _counter = 0;
        }

        public int Length { get => _counter; }
        private List<string> Items { get; set; }

        public void Add(string v)
        {
            if (Items.Contains(v))
            {
                var tmp = Items.IndexOf(v);
                Items[tmp] = Items[_counter - 1];
                Items[_counter - 1] = v;
                return;
            }

            Items.Add(v);
            _counter++;
        }

        public string getByIndex(int v)
        {
            return Items[(_counter - 1) - v];
        }
    }
}
