public class Solution {
    public int MinStartValue(int[] nums) {

        var prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];

        for (int i = 1; i < nums.Length; ++i)
            prefixSum[i] = prefixSum[i-1] + nums[i];
        
        Array.Sort(prefixSum);

        return prefixSum[0] > 0 ? 1 : Math.Abs(prefixSum[0]) + 1;
    }
}