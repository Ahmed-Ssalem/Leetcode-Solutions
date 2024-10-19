public class Solution {
    public int[] SeparateDigits(int[] nums) {
        
        var seperatedDigits = new Stack<int>();

        for(int i = nums.Length - 1; i >= 0; --i)
            while(nums[i] > 0){
                seperatedDigits.Push(nums[i] % 10);
                nums[i] /= 10;
            }
        
        return seperatedDigits.ToArray();
    }
}