class Solution {
public:
    int maximumWealth(vector<vector<int>>& accounts) {
        int sum = 0, res = 0;
        
        for (int i = 0; i < accounts.size(); ++i){
            for (int j = 0; j < accounts[i].size(); ++j){
                sum += accounts[i][j];
            }
            res = max(sum, res);
            sum = 0;
        } 
        return res;
    }
};