public class Solution {
    public int MaxProductDifference(int[] nums) {
        Array.Sort(nums);
        return (nums[nums.Length - 1] * nums[nums.Length - 2]) - (nums[0] * nums[1]);
    }
}