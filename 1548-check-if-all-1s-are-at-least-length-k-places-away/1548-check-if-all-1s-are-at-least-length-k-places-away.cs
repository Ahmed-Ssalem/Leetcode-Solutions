public class Solution {
    public bool KLengthApart(int[] nums, int k) 
    {
        int last = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                if (last != 0 && i - last - 1 < k)
                    return false;

                last = i;
            }
        }
        return true;
    }
}