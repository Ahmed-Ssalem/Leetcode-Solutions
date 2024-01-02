public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
       
        int res = 0;
        Array.Sort(g);
        Array.Sort(s);
        for (int i = 0; i < g.Length; ++i){
            for (int j = 0; j < s.Length; ++j){
                if (g[i] <= s[j]){
                    res++;
                    s[j] = 0;
                    break;
                }
            }
        }
        return res;
    }
}