public class Solution {
    public int Jump(int[] nums) {
        
        int jumbs = 0, farthest = 0, currentEnd = 0;
        
        for (int i = 0; i < nums.Length - 1; ++i){
            farthest = Math.Max(farthest, i + nums[i]);
            if (i == currentEnd){
                jumbs++;
                currentEnd = farthest;
            }
        }
        return jumbs;
    }
}