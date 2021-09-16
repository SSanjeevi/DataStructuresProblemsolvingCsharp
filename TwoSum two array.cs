public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
            {
                int[] result = { left + 1, right + 1 };
                return result;
            }
            else if (numbers[left] + numbers[right] > target)
            {
                right = right - 1;
            }
            else
            {
                left++;
            }
        }
        return null;
    }
}
