public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var numsMapping = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; ++i)
        {
            if (numsMapping.ContainsKey(target - nums[i]))
                return new int[] {numsMapping[target - nums[i]], i};
            
            numsMapping[nums[i]] = i;
        }

        return new int[0];
    }
}