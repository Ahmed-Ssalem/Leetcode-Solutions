public class Solution {
    public double MinimumAverage(int[] nums) {
        
        double res = Double.MaxValue;
        var indx = nums.Length - 1;
        Array.Sort(nums);

        for (int i = 0; i < nums.Length / 2; ++i){
            var sum = (double)(nums[i] + nums[indx]) / 2;
            if (sum < res )
                res = sum;
            indx--;
        }
        return res;
    }
}