class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        int n = s.size(), i =0, j = 0;
        if (n == 0)
            return 0;
        set <char> st;
        int maxSize = 0;
        while (i < n){
            if(st.count(s[i]) == 0){
                st.insert(s[i]);
                maxSize = max(maxSize, (int)st.size());
                ++i;
            }
            else{
                st.erase(s[j]);
                j++;
            }
        }
        return maxSize;
    }
};