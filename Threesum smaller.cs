public class Solution
{
    public int ThreeSumSmaller(int[] nums, int target)
    {
        int count = 0;
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum < target)
                {
                    count += right - left;
                    left++;
                }

                else
                {
                    right--;
                }
            }
        }
        return count;

    }
}