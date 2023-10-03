namespace CodeKata
{
    public class RemoveDuplicates
    {
        public int Remove(int[] nums)
        {
            int result = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 >= nums.Length)
                    break;

                if (nums[i] == nums[i + 1])
                {
                    i++;
                    result--;
                    if (i >= nums.Length)
                        break;
                    nums[i] = nums[i + 1];
                }
            }

            return result;
        }
    }
}
