class Solution {
public:
    char findTheDifference(string s, string t) {
        sort(s.begin(), s.end());
        sort(t.begin(), t.end());
        int sz = t.size();
        char res;
        for (int i = 0; i < sz; ++i){
            if(t[i] != s[i]){
                res = t[i];
                break;
            }
        }
        return res;
    }
};