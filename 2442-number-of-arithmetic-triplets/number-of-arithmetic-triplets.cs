public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {

        var hs = new HashSet<int>(nums);
        var res = 0;

        for (int i = 1; i < nums.Length -1; ++i)
            if (hs.Contains(nums[i] - diff) && hs.Contains(nums[i] + diff))
                res++;

        return res;        
    }
}