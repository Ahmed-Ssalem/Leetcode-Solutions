public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        if (s.Length == 0)
            return true;

        var pointer = 0;

        foreach (var c in t)
            if (pointer < s.Length && s[pointer] == c)
                pointer++;
            
        
            
        
        return pointer == s.Length;
    }
}