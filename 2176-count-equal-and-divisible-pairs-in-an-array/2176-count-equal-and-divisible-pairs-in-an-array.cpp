class Solution {
public:
    int countPairs(vector<int>& nums, int k) {
        int res = 0;
        for (int i = nums.size() - 1; i > 0; --i)
            for (int j = 0; j < i; ++j)
                if (nums[i] == nums[j] && (i * j) % k == 0)
                    res++;
        return res;    
        
        
    }
};