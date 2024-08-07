public class Solution {
    public bool CanAliceWin(int[] nums) {
        
        int sumSingle = 0, sumDouble = 0;
        
        for (int i = 0; i < nums.Length; i++){
            if(nums[i] < 10)
                sumSingle += nums[i];
            else
                sumDouble += nums[i];
        }
        
        return sumSingle != sumDouble;
    }
}