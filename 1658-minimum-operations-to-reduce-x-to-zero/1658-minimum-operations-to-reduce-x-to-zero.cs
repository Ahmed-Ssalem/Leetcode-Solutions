public class Solution {
    public int MinOperations(int[] nums, int x) {
        int sum = 0, l = 0, res = 0, n = nums.Length, maxi = -1;
        foreach(int i in nums)
            sum +=i;
        for (int i = 0; i < nums.Length; ++i){
            res += nums[i];
            while ((l < n) && (sum - x < res)){
                res -= nums[l];
                l++;
            }
            if (sum - res == x)
                maxi = Math.Max( (i - l + 1), maxi);
        }
        if (maxi == -1)
            return -1;
        return n - maxi;
    }
}