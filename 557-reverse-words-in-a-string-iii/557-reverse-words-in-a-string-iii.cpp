class Solution {
public:
    string reverseWords(string s) {
        
        string res = "", ans = "";       
        for (int i = 0; i < s.size(); ++i){
            if (s[i] != ' ')
                ans += s[i];
            else{
                for (int j = ans.size() - 1; j >= 0; --j)
                    res += ans[j];
                res += ' ';
                ans = "";
            }
        }
        for (int j = ans.size() - 1; j >= 0; --j)
                res += ans[j];
        
        return res;
    }
};