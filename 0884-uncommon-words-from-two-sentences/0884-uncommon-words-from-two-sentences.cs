public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        
        string s = s1 + " " + s2;

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        string[] words = s.Split(' ');

        foreach (string word in words) {
            if (wordCount.ContainsKey(word)) {
                wordCount[word]++;
            } else {
                wordCount[word] = 1;
            }
        }

        List<string> result = new List<string>();

        foreach (var entry in wordCount) {
            if (entry.Value == 1) {
                result.Add(entry.Key);
            }
        }

        return result.ToArray();
    }
}