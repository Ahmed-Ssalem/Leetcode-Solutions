public class Solution {
    public int MaxPower(string s) {
        int len = 1, maxLen = 0;
        for (int i = 1; i < s.Length; ++i)
        {
            if (s[i] == s[i-1])
            {
                len++;
                maxLen = Math.Max(maxLen, len);
            }
            else
                len = 1;
        }
        return maxLen;
    }
}