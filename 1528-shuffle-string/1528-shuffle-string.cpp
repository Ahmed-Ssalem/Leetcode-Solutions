class Solution {
public:
    string restoreString(string s, vector<int>& indices) {
        string res = "";
        
        map <int, char> m;
        
        for (int i = 0; i < s.length(); ++i){
            m.insert({indices[i], s[i]});
        }
        for (auto itr = m.begin(); itr != m.end(); ++itr) {
            res += itr->second;
        }
        return res;
    }
};