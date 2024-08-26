public class Solution {
    public int BalancedStringSplit(string s) {
        
        int l = 0, r = 0, res = 0; 
        
        for (int i = 0; i < s.Length; ++i){
            
            if (s[i] == 'L') ++l;
            else ++r;

            if (l == r){
                ++res;
                l = 0;
                r = 0;
            }
        }
        return res;
    }
}