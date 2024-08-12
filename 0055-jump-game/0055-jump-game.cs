public class Solution {
    public bool CanJump(int[] nums) {
        
        var maxReach = 0;

        for (int i = 0; i < nums.Length; ++i){
            
            if (i > maxReach) 
                return false;

            maxReach = Math.Max(maxReach, i + nums[i]);
            
            if (maxReach >= nums.Length - 1) 
                return true;
        }
        return false;
    }
}