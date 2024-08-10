public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        var replaceIndex = 0;

        for (int i = 0; i < nums.Length; ++i){
            if (replaceIndex - 2 >= 0 && nums[replaceIndex-2] == nums[i])
                continue;
            nums[replaceIndex] = nums[i];
            replaceIndex++;
        }
        return replaceIndex;
    }
}