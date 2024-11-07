public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char ch in s) {
            
            if (charCount.ContainsKey(ch)) 
                charCount[ch]++;
            else 
                charCount[ch] = 1;
            
        }

        foreach (char ch in t) {
            
            if (!charCount.ContainsKey(ch)) 
                return false;
            
            charCount[ch]--;

            if (charCount[ch] == 0) 
                charCount.Remove(ch);
            
        }

        return charCount.Count == 0;
    }
}