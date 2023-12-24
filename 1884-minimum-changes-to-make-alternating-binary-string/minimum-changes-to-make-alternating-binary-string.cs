public class Solution {
    public int MinOperations(string s) {
        
        int res1 = 0, res2 = 0, len = s.Length;

        for (int i = 0; i < len; i+=2){
            
            if (s[i] != '0') res1++;
            else res2++;

            if (i != len-1 && s[i+1] != '1') res1++;
            else if (i != len-1 && s[i+1] == '1') res2++;
        }
        return Math.Min(res1, res2);
    }
}