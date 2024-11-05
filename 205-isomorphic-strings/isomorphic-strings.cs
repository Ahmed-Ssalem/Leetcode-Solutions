public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
        if (s.Length != t.Length)
            return false;
        
        var mapST = new Dictionary<char, char>();
        var mapTS = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; ++i)
        {
            if (mapST.ContainsKey(s[i]))
            {
                if (mapST[s[i]] != t[i])
                    return false;
            }
            else
                mapST[s[i]] = t[i];
            
            if (mapTS.ContainsKey(t[i]))
            {
                if (mapTS[t[i]] != s[i])
                    return false;
            }
            else
                mapTS[t[i]] = s[i];
        }
        return true;
    }
}