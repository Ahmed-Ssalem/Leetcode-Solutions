class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        map <int, int> m;
        vector <int> v;
        
        for (int i = 0; i < nums.size(); ++i)
            for (int j = 1; j < nums.size(); ++j)
                if (nums[i] + nums[j] == target && i < j)
                    if (!m[i] && !m[j])
                        m[i]++, m[j]++, v.push_back(i), v.push_back(j);
        
        return v;
    }
};