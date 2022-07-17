class Solution {
public:
    bool areOccurrencesEqual(string s) {
        
        unordered_map<char, int> m;
        
        for (int i = 0; i < s.size(); ++i)
            m[s[i]]++;

        int res = m[s[0]];
        
        for(auto &it : m)
            if (res != it.second){
                return false;
                break;
            }
        
        return true;
    }
};