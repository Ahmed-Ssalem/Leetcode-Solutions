class Solution {
public:
    int numOfStrings(vector<string>& patterns, string word) {
        
        int res = 0;
        for (string s : patterns){
            bool found = word.find(s) != string::npos;
            if (found)
                res++;
        }
        return res;
        
    }
};