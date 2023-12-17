public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
       
        List<int> res = new List<int>();
        for (int i = 0; i < words.Length; ++i)
            if (words[i].Contains(x))
                res.Add(i);
        
        return res;
    }
}