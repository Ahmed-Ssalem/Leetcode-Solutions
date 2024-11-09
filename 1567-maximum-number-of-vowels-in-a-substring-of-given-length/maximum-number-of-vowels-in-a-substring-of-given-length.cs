public class Solution {
    public int MaxVowels(string s, int k) {
       
        int maxVowels = 0, windowVowels = 0;
       
        HashSet<char> vowels = new HashSet<char>();
        vowels.Add('a'); vowels.Add('e'); vowels.Add('i'); vowels.Add('o'); vowels.Add('u');

        for (int i = 0; i < k; ++i)
            if(vowels.Contains(s[i]))
                windowVowels++;

        maxVowels = windowVowels;

        for (int i = k; i < s.Length; ++i)
        {
            if (vowels.Contains(s[i-k]))
                windowVowels--;

            if (vowels.Contains(s[i]))
                windowVowels++;
                
            maxVowels = Math.Max(maxVowels, windowVowels);
        }
        return maxVowels;
    }
}