public class Solution {
    public bool IsValid(string word) {

        if (word.Length < 3)
            return false;

        bool vowel = false;
        bool constant = false;
        
        foreach (char c in word)
        {
            if (!char.IsLetterOrDigit(c))
                return false;
            else if (char.IsDigit(c))
                continue;
            else if ("aeiouAEIOU".IndexOf(c) >= 0)
                vowel = true;
            else 
                constant = true;
        }
        return vowel && constant;
    }
}