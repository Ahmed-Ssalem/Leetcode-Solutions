class Solution {
public:
    int mostWordsFound(vector<string>& sentences) {
        int res = 0;
        for (auto &sentence : sentences){
            int sum = 1;
            for (int i = 0; i < sentence.length(); ++i){
                 if (sentence[i] == ' ')
                     ++sum;
            }
            res = max(sum, res);
            
        }
        return res;
    }
};