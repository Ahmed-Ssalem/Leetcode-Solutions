class Solution {
    
public:
    char shift(char c1, char c2){
        c1 -= 0;
        int a = c2 - 48;
        return c1 += a;
    }
    
public:
    string replaceDigits(string s) {
        string res = "";
        for (int i = 0; i < s.size(); ++i){
            if (i % 2 == 0)
                res.push_back(s[i]);
            else
                res.push_back(shift(s[i-1], s[i]));
            
        }
        return res;
    }
};