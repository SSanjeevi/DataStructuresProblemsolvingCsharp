public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int left = 0;

        if (nums != null && nums.Length >= 1)
        {
            for (int right = 1; left < nums.Length && right < nums.Length; right++)
            {
                if (nums[left] != nums[right])
                {
                    left++;
                    nums[left] = nums[right];
                }
            }
            return left + 1;
        }
        return left;
    }
}