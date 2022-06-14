class Solution {
public:
    
    int dp[501][501];
    
    int minDistance(string word1, string word2) {
        memset(dp, -1, sizeof dp);
        return word1.size() + word2.size() - (2 * lcs(word1, word2, 0, 0));
    }
    
    int lcs(string word1, string word2, int i, int j){
        
        if (i == word1.size() || j == word2.size())
            return 0;
        
        if (dp[i][j] != -1)
            return dp[i][j];
        
        int msc = 0;
        
        if (word1[i] == word2[j])
            msc = max(msc, 1 + lcs(word1, word2, i+1, j+1));
        else{
            msc = max(msc, lcs(word1, word2, i+1, j));
            msc = max(msc, lcs(word1, word2, i, j+1));    
        }
        
    
        return dp[i][j] = msc;
    }
    

};