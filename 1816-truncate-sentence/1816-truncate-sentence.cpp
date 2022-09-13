class Solution {
public:
    string truncateSentence(string s, int k) {
        string res = "";
        for (int i = 0; i < s.size(); ++i){
            
            if (k != 0 && s[i] == ' '){
                k--;
                if (k == 0)
                    break;
            }
            
            
            res += s[i];
            
        }
        return res;
    }
};