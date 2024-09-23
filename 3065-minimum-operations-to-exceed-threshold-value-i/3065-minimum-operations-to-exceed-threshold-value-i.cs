public class Solution {
    public int MinOperations(int[] nums, int k) {
        
        int res = 0;
        
        foreach (var num in nums)
            if (num < k)
                res++;
        
        return res;
    }
}