public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        
        int sum = 0, sum2 = 0;
        
        int[] right = new int[nums.Length];
        right[nums.Length-1] = 0;
        
        int[] left = new int[nums.Length];
        left[0] = 0;
        
        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; ++i){
            sum += nums[i];
        }
        
        sum2 = sum;

        for (int i = 0; i < nums.Length-1; ++i){
            right[i] = sum2 - nums[i];
            sum2 -= nums[i];
        }

        for (int i = nums.Length-1; i > 0; --i){
            left[i] = sum - nums[i];
            sum -= nums[i];
        }

        for (int i = 0; i < nums.Length; ++i){
            res[i] = Math.Abs(left[i]- right[i]);
        }

        return res;
    }
}