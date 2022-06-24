class Solution {
public:
    int numIdenticalPairs(vector<int>& nums) {
        map <int, int> m;
        int res = 0;
        
        for (int i = 0; i < nums.size(); ++i)
            m[nums[i]]++;
        
        for (auto itr = m.begin(); itr != m.end(); ++itr) 
            res += (itr->second * (itr->second - 1)) / 2;
        
        return res;
    }
};