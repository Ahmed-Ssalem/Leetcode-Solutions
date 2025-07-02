public class Solution {
    public int NumSubseq(int[] nums, int target) {
        
        Array.Sort(nums);
        int res = 0, mod = (int)1e9 + 7;
        List<int> pow = new List<int>(){1};
        
        for (int i = 1; i < (int)1e5; i++)
            pow.Add((2 * pow[i - 1]) % mod) ;
        

        for (int i = 0; i < nums.Length; i++)
        {
            int left = i, right = nums.Length - 1, idx = -1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[i] + nums[mid] <= target)
                {
                    idx = mid;
                    left = mid + 1;
                }
                else 
                    right = mid - 1;
            }
            if (idx != -1) 
            { 
                res += pow[idx - i]; 
                res %= mod;
            }
        }
        return res;
    }
}