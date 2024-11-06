public class Solution {
    public bool WordPattern(string pattern, string s) {
        
        string[] words = s.Split(' ');
        Dictionary<char, string> wordPattern = new Dictionary<char, string>();

        for (int i = 0; i < pattern.Length; ++i)
        {
            if (wordPattern.ContainsKey(pattern[i]) && wordPattern[pattern[i]] != words[i])
                return false;
            else
                wordPattern[pattern[i]] = words[i];
        }
        return true;
    }
}