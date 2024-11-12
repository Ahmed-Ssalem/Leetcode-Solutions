public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int len = 0, maxLen = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 1)
            {
                len++;
                maxLen = Math.Max(maxLen, len);
            }
            else
                len = 0;
        }
        return maxLen;
    }
}