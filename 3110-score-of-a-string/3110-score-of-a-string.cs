public class Solution {
    public int ScoreOfString(string s) {
        
        var res = 0;
        
        for (int i = 0; i < s.Length-1; ++i)
            res += Math.Abs(s[i] - s[i+1]);
        
        return res;
    }
}