public class Solution {
    public int LongestOnes(int[] nums, int k) {
        
        int zerosCount= 0, start = 0, maxOnes = 0;

        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 0)
                ++zerosCount;
            
            while (zerosCount > k)
            {
                if (nums[start] == 0)
                    --zerosCount;
                ++start;
            }
            maxOnes = Math.Max(maxOnes, i - start + 1);
        }
        return maxOnes;
    }
}