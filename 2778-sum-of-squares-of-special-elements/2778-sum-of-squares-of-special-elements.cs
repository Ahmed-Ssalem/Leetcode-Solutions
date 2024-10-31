public class Solution {
    public int SumOfSquares(int[] nums) {

        var n = nums.Length;
        var res = 0;

        for (int i = 0; i < n; ++i)
            if (n % (i + 1) == 0)
                res += nums[i] * nums[i];
        
        return res;
    }
}