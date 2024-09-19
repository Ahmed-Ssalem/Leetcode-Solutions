public class Solution {
    public int MaxOperations(int[] nums, int k) {
        
        Array.Sort(nums);
        int left = 0, right = nums.Length - 1, res = 0;

        while (right > left)
        {
            if (nums[left] + nums[right] == k)
            {
                res++;
                left++;
                right--;
            }
            else if (nums[left] + nums[right] > k)
                right--;
            else
                left++;
        }
        return res;
    }
}