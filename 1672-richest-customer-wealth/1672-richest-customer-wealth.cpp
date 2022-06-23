class Solution {
public:
    int maximumWealth(vector<vector<int>>& accounts) {
        int res = 0;
        
        for (auto &customer : accounts)
            res = max (res, accumulate(customer.begin(), customer.end(), 0));
        
        return res;
    }
};