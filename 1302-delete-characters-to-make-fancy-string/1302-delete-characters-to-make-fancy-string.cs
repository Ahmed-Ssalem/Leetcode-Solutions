public class Solution {
    public string MakeFancyString(string s) {
        
        if (s.Length < 3)
            return s;
            
        List<char> res = new List<char>();

        for (int i = 0; i <= s.Length - 3; ++i)
        {
            if (s[i] == s[i+1] && s[i+1] == s[i+2])
                continue;
            else
                res.Add(s[i]);
        }
        res.Add(s[s.Length-2]);
        res.Add(s[s.Length-1]);

        return new string(res.ToArray());
    }
}