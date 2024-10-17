public class Solution {
    public int MaximizeSum(int[] nums, int k) {

        int max = nums.Max();
        int c = max;
        for(int i = 1; i < k; i++)
        {
            max += 1;
            c += max;
        }
        return c;
    }
}