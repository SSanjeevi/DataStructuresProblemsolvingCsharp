public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int diff = int.MaxValue;
        int sum = 0;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length && diff != 0; ++i)
        {
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                int tot = nums[left] + nums[right] + nums[i];
                int currentDiff = target - tot;
                if ((Math.Abs(target - tot)) < Math.Abs(diff))
                {
                    diff = currentDiff;
                }
                if (tot < target)
                {
                    ++left;
                }
                else
                {
                    --right;
                }
            }
        }

        return target - diff;
    }

}