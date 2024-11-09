public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        
        var sum = 0.0;

        for (int i = 0; i < k; ++i)
            sum += nums[i];
        
        var maxSum = sum;
        var start = 0;
        var end = k;

        while (end < nums.Length)
        {
            sum -= nums[start];
            ++start;

            sum += nums[end];
            ++end;

            maxSum = Math.Max(maxSum, sum);
        }

        return maxSum / k;
    }
}
