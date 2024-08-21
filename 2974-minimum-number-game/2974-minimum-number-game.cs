public class Solution {
    public int[] NumberGame(int[] nums) {
        
        Array.Sort(nums);
        int num = 0;
        
        for (int i = 0; i < nums.Length - 1; i+=2){
            num = nums[i];
            nums[i] = nums[i+1];
            nums[i+1] = num;
        }
        
        return nums;
    }
}