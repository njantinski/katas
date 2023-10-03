namespace CodeKata
{
    public class KarateChop
    {
        public int BinarySearchIterative(int[] array, int number)
        {
            int high = array.Length - 1;
            int low = 0;
            int mid = high / 2;
            int index = -1;

            for (int i = low; i < high; i++)
            {
                if (array[i] == number)
                {
                    index = i;
                    break;
                }
                if (array[i] < number)
                {
                    low = mid + 1;
                    mid = (high + low) / 2;
                }
                else if (array[i] > number)
                {
                    high = mid - 1;
                    mid = (low + high) / 2;
                }
            }

            return index;
        }
        public int BinarySearchRecursion(int[] array, int number, int low, int high)
        {
            if (low > high)
                return -1;
            else
            {
                int mid = (high + low) / 2;
                if (array[mid] == number)
                    return mid;
                if (array[mid] < number)
                    low = mid + 1;
                else
                    high = mid - 1;

                return BinarySearchRecursion(array, number, low, high);
            }
        }
    }
}