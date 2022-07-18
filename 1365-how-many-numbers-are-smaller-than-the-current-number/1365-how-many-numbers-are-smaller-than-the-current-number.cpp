class Solution {
public:
    vector<int> smallerNumbersThanCurrent(vector<int>& nums) {
        map <int, int> m;
        vector<int> v = nums;
        sort(v.begin(), v.end());
        int sz = v.size();
        
        m[v[0]] = 0;
        
        for (int i = 1; i < sz; ++i){
            if (v[i] != v[i-1])
                m[v[i]] = i;
            else
                m[v[i]] = m[v[i-1]];  
        }
        
        vector <int> res;
        
        for (int i = 0; i < sz; ++i){
            res.push_back(m[nums[i]]);
        }
        
        return res;
    }
};