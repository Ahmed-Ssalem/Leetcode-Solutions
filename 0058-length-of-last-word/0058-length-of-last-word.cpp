class Solution {
public:
    int lengthOfLastWord(string s) {
        
        int sizeS = s.size() - 1;
        int end;
        for (int i = sizeS; i >= 0; --i){
            if (s[i] == ' ')
                continue;
            else{
                end = i;
                break;
            }
        }
        vector<char> c;
        for (int i = end; i >= 0; --i){
            if (s[i] != ' ')
                c.push_back(s[i]);
            else 
                break;
        }
        return c.size();
    }
};