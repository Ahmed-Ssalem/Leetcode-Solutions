class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {    
        
        unordered_map<int, int> count;
        sort(nums.begin(), nums.end());
        
        for (int i = 0; i < nums.size(); ++i){
            count[nums[i]]++;
            if(count[nums[i]] == 2)
                return true;
        }
        return false;
    }
};


