public class Solution {
    public int FindPermutationDifference(string s, string t) {

        var res = 0; 
        Dictionary<char, int> indxOfT = new Dictionary<char, int>();
        
        for (int i = 0; i < t.Length; ++i)
            indxOfT[t[i]] = i;
        
        for (int i = 0; i < s.Length; ++i)
            res += Math.Abs(i - indxOfT[s[i]]);
        
        return res;
    }
}