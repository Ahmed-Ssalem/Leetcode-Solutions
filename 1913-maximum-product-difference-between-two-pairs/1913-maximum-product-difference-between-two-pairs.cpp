class Solution {
public:
    int maxProductDifference(vector<int>& nums) {
        
        int sz = nums.size();
        sort(nums.begin(), nums.end());
        int res = (nums[sz-1] * nums[sz-2]) - (nums[0] * nums[1]);
        
        return res;
    }
};