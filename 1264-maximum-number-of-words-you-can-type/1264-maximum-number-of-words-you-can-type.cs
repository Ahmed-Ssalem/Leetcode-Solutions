public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        
        string [] words = text.Split(' ');
        int res = 0; 
        
        foreach (string word in words)   
            foreach (char c in brokenLetters)
                if (word.Contains(c))
                {
                    res++;
                    break; 
                }
                   
        return Math.Abs(words.Length - res);
    }
}