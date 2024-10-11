public class Solution {
    public int CountKeyChanges(string s) {
        
        var word = s.ToLower();
        var res = 0;

        for (int i = 0; i < word.Length - 1; ++i)
            if (word[i] != word[i+1])
                res++;

        return res;
    }
}