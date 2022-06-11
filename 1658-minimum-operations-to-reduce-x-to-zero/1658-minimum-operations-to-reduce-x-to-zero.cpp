class Solution {
public:
    int minOperations(vector<int>& nums, int x) {
        int sum = 0, l = 0, maxi = -1, n = nums.size(), res = 0;
        for (int i : nums)
            sum += i;
        for (int i = 0; i < n; ++i){
            res += nums[i];
            while( (l < n) && (sum - x < res) ){
                res -= nums[l];
                l++;
            }
            if (sum - res == x)
                maxi = max( (i - l + 1), maxi);
        }
        if (maxi == -1)
            return -1;
        return n - maxi;
        
    }
};