public class Solution {
    public bool CheckIfPangram(string sentence) {
        
        var englishAlphabet = new Dictionary<char, int>();

        foreach (var ch in sentence)
        {
            if (englishAlphabet.ContainsKey(ch))
                englishAlphabet[ch]++;
            else
                englishAlphabet.Add(ch, 0);
        }
            
        
        return englishAlphabet.Count == 26 ? true : false;
    }
}