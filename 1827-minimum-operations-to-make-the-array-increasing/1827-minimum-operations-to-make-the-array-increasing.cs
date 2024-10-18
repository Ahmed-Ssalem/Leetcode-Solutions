public class Solution {
    public int MinOperations(int[] nums) {

        var res = 0;
        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] <= nums[i-1])
            {
                var subtract = nums[i-1] - nums[i] + 1;
                nums[i] +=  subtract;
                res += subtract;
            }
        }
        return res;
    }
}