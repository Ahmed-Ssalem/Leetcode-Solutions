public class Solution {
    public int LongestSubarray(int[] nums) {
        
        int zerosCount = 0, res = 0, start = 0;
        
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 0)
                ++zerosCount;
            while (zerosCount > 1)
            {
                if (nums[start] == 0)
                    --zerosCount;
                ++start;
            }
            res = Math.Max(res, i - start);
        }
        return res;
    }
}