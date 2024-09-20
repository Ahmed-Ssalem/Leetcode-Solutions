public class Solution {
    public int PivotIndex(int[] nums) {
        
        int rightSum = nums.Sum(), leftSum = 0;

        for (int i = 0; i < nums.Length; ++i)
        {
            rightSum -= nums[i];

            if (rightSum == leftSum) 
                return i;
            
            leftSum += nums[i];
        }
        return -1;
    }
}