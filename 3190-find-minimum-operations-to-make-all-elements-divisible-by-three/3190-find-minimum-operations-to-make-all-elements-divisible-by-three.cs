public class Solution {
    public int MinimumOperations(int[] nums) {

        var res = 0;
        for (var i = 0; i < nums.Length; ++i)
            if (nums[i] % 3 != 0)
                res++;
        return res;
        
    }
}