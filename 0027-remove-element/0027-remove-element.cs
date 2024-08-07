public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        var countRemovableNums = 0;
        
        for(var i = 0; i < nums.Length; ++i)
            if (nums[i] == val){
                nums[i] = -1;
                countRemovableNums++;
            }
        
        Array.Sort(nums, (x, y) => y.CompareTo(x));

        return nums.Length - countRemovableNums;
    }
}