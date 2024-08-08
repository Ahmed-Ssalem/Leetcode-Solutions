public class Solution {
    public int RomanToInt(string s) {
        
        Dictionary<char,int> romanChars = new Dictionary<char,int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        var res = 0;
        for (int i = 0; i < s.Length; )
        {
            if (i+1 < s.Length && romanChars[s[i]] < romanChars[s[i+1]])
            {
                res += romanChars[s[i+1]] - romanChars[s[i]];
                i += 2;
            }
            else
            {
                res += romanChars[s[i]];
                ++i;
            }
                
        }
        return res;
    }
}