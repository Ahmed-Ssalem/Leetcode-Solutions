public class Solution {
    public int MinimumMoves(string s) {
        
        int len = s.Length, res = 0;
        for (int i = 0; i < len; ++i)
        {
            if (s[i] == 'X')
            {
                res++;
                i += 2;
            }
        }
        return res;
    }
}