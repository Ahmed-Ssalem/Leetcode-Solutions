class Solution {
public:
    int maxNumberOfBalloons(string s) {
        
        map <char, int> m;
        int res = 0;
        for (int i = 0; i < s.size(); ++i)
            m[s[i]]++;
        
        while (m['b'] >= 1 && m['a'] >= 1 && m['l'] >= 2 && m['o'] >= 2 && m['n'] >= 1)
            m['b']--, m['a']--, m['l'] -= 2, m['o'] -= 2, m['n']--, res++;
        
        return res;
    }
};