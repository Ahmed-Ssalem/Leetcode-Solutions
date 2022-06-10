public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var n = s.Length;
        var i = 0; 
        var j = 0; 
        var maxSize = 0;
        
        HashSet<char> st = new HashSet<char>();
        
        if (s.Length == 0)
            return 0;
        
        while (i < n){
            if (!st.Contains(s[i])){
                st.Add(s[i]);
                maxSize = Math.Max(maxSize, (int)st.Count);
                ++i;
            }
            else{
                st.Remove(s[j]);
                ++j;
            }
        }
        return maxSize;
    }
}