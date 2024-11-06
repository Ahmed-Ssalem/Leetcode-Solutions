public class Solution {
    public bool WordPattern(string pattern, string s) {
        
        string[] words = s.Split(' ');

        if (words.Length != pattern.Length) 
            return false;

        Dictionary<char, string> wordPattern = new Dictionary<char, string>();
        Dictionary<string, char> wordReversePattern = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; ++i)
        {
            if (wordPattern.ContainsKey(pattern[i]) && wordPattern[pattern[i]] != words[i])
                return false;
            else
                wordPattern[pattern[i]] = words[i];
            
            if (wordReversePattern.ContainsKey(words[i]) && wordReversePattern[words[i]] != pattern[i])
                return false;
            else
                wordReversePattern[words[i]] = pattern[i];
        }
        return true;
    }
}