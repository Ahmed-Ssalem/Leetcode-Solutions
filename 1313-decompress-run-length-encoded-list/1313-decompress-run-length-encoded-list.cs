public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        
        List<int> res = new List<int>();
        
        for (int i = 0; i <= nums.Length - 2; i += 2)
            while(nums[i] > 0){
                res.Add(nums[i+1]);
                --nums[i];
            }
        
        return res.ToArray();
    }
}