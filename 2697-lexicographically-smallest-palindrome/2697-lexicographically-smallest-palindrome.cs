public class Solution {
    public string MakeSmallestPalindrome(string s) {

        char[] c = s.ToCharArray();

        for (int i = 0, j = c.Length - 1; i < c.Length && j >= 0; ++i, --j)
        {
            if (c[i] != c[j])
            {
                if (c[i] < c[j])
                    c[j] = c[i];
                else
                    c[i] = c[j];
            }
        }
        
        var res = new string(c);
        return res;
    }
}