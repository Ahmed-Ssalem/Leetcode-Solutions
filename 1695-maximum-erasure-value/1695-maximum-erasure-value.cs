public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        
        int left = 0;
        int currSum = 0;
        int maxSum = 0;
        
        HashSet<int> set = new HashSet<int>();

        for (int right = 0; right < nums.Length; right++)
        {
            while (set.Contains(nums[right]))
            {
                set.Remove(nums[left]);
                currSum -= nums[left];
                left++;
            }
            set.Add(nums[right]);
            currSum += nums[right];
            maxSum = Math.Max(currSum, maxSum);
        }

        return maxSum;
    }
}