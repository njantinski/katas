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

        public RecentlyUsedList(int capacity)
        {
            Items = new List<string>(2);
            _counter = 0;
        }

        public int Length { get => _counter; }
        private List<string> Items { get; set; }

        public void Add(string v)
        {
            if (string.IsNullOrEmpty(v))
                return;

            if (Items.Contains(v))
            {
                var tmp = Items.IndexOf(v);
                Items[tmp] = Items[_counter - 1];
                Items[_counter - 1] = v;
                return;
            }


            if (_counter == Items.Capacity)
            {
                Items.RemoveAt(0);
            }

            Items.Add(v);

            if (_counter < Items.Capacity)
                _counter++;
        }

        public string getByIndex(int v)
        {
            if (v < 0)
                throw new Exception("Negative numbers not allowed");


            return Items[(_counter - 1) - v];
        }
    }
}
