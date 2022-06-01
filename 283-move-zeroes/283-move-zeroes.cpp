class Solution {
public:
    void moveZeroes(vector<int>& nums) {
        vector<int> ans;
        for(auto x : nums){
            if (x != 0)
                ans.push_back(x);
        }
        for(auto x : nums){
            if (x == 0)
                ans.push_back(x);
        }
        nums.erase(nums.begin(),nums.end());
        for(auto x:ans){
            nums.push_back(x);
        }
        
    }
};