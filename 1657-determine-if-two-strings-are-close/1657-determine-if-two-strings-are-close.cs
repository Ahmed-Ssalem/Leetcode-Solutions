public class Solution {
    public bool CloseStrings(string word1, string word2) {
        
        if (word1.Length != word2.Length)
            return false;

        var countFrequenciesOfWord1 = new int[26];
        var countFrequenciesOfWord2 = new int[26];
        var charsOfWord1 = new HashSet<char>();
        var charsOfWord2 = new HashSet<char>();

        foreach (var c in word1.ToCharArray()){
            countFrequenciesOfWord1[c - 'a']++;
            charsOfWord1.Add(c);
        }

        foreach (var c in word2.ToCharArray()){
            countFrequenciesOfWord2[c - 'a']++;
            charsOfWord2.Add(c);
        }
        Array.Sort(countFrequenciesOfWord1);
        Array.Sort(countFrequenciesOfWord2);
        
        return charsOfWord1.SetEquals(charsOfWord2) && countFrequenciesOfWord1.SequenceEqual(countFrequenciesOfWord2); 
    }
}