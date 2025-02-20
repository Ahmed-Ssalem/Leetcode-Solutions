public class Solution {
    public int FirstUniqChar(string s) {
        
        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach(char c in s)
        {   
            if (!counts.ContainsKey(c))
                counts[c] = 1;
            else
                counts[c] += 1;
        }

        for (int i = 0; i < s.Length; ++i)
            if (counts[s[i]] == 1)
                return i;

        return -1;
    }
}