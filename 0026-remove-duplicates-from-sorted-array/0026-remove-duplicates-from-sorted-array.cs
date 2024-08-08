public class Solution {
    public int RemoveDuplicates(int[] nums) {
       
       int k = nums.Length;
       List<int> list = new List<int>();

        for (int i = 0; i < nums.Length; ++i){
            if (list.Contains(nums[i]))
                k--;
            else 
                list.Add(nums[i]);
        }

        for (int i = 0; i < k; ++i)
            nums[i] = list[i];
        
        return k;
    }
}