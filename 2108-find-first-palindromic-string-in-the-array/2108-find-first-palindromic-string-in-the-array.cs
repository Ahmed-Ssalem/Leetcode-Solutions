public class Solution {
    public string FirstPalindrome(string[] words) {
        
        foreach (var word in words)
            if (IsPalindromic(word))
                return word;
        
        return "";
    }

    private bool IsPalindromic (string word)
    {
        int len = word.Length;

        for (int i = 0; i < len / 2; ++i)
            if (word[i] != word[len - i - 1])
                return false;
        
        return true;
    }
}