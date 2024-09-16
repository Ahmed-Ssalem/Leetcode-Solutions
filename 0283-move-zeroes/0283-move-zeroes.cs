public class Solution {
    public void MoveZeroes(int[] nums) {
        
        var pointer = 0;        

        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != 0)
            {
                (nums[pointer], nums[i]) = (nums[i], nums[pointer]);
                pointer++;
            }
        }
    }
}