public class Solution {
    public int MaxScore(string s) {
        
        int ones = 0, zeroes = 0, res = 0;

        for (int i = 0; i < s.Length; ++i)
            if (s[i] == '1')
                ones++;
        
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '0')
                zeroes++;
            else
                ones--;

            if (ones + zeroes > res)
                res = ones + zeroes;
        }
        return res;
    }
}