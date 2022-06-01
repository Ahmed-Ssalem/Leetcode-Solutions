class Solution {
public:
    vector<int> runningSum(vector<int>& nums) {
        vector<int> sum;
        int ans = 0;
        
        for (int i = 0; i < nums.size(); ++i){
            ans += nums[i];
            sum.push_back(ans);
        }
        return sum;
    }
};