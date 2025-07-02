public class Solution {
    public int NumSubseq(int[] nums, int target) {
        
        Array.Sort(nums);
        int res = 0, mod = (int)1e9 + 7;
        List<int> pow = new List<int>(){1};
        
        for (int i = 1; i < (int)1e5; i++)
            pow.Add((2 * pow[i - 1]) % mod) ;
        
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            if (nums[left] + nums[right] <= target)
            {
                res = (res + pow[right - left]) % mod;
                left++;
            }
            else 
                right--;
        }

        return res;
    }
}