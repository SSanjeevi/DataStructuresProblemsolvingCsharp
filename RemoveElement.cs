public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int left = 0;

        if (nums != null && nums.Length >= 1)
        {
            for (int right = 0;left < nums.Length && right < nums.Length; right++)
            {
                if (nums[right] !=val)
                {
                    nums[left] = nums[right];
                    left++;
                }
            }
            return left;
        }
        return left;
    }
}s