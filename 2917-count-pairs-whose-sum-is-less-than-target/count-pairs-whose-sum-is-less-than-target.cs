public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        int res = 0;
        for (int i = 0; i < nums.Count; ++i)
            for (int j = 1; j < nums.Count; ++j)
                if (i < j)
                    if (nums[i] + nums[j] < target)
                        res++;
        return res;
    }
}