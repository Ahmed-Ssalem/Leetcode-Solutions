public class Solution {
    public int MaximumCount(int[] nums) {
        
        int pos = 0, neg = 0;

        foreach (int num in nums)
        {
            if (num > 0) 
                pos++;
            else if (num < 0)
                neg++;
        }

        return pos > neg ? pos : neg;
    }
}