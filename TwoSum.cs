public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> position = new Dictionary<int,int>();
        for(int i =0; i< nums.Length; i++)
        {
            if(!position.ContainsKey(nums[i]))
            {
            position.Add( nums[i], i);
        }
}
        
        for(int i =0; i< nums.Length; i++)
        {
            int diff = target - nums[i];
            if(position.ContainsKey(diff) && position[diff] != i)
            {
                int[] result = {i, position[diff]};
                return result;                
            }
}
    return null;
        
    }
    
}