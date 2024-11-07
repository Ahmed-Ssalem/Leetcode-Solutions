public class Solution {
    public bool IsAnagram(string s, string t) {

        char[] ss = s.ToCharArray();
        char[] tt = t.ToCharArray();
        
        Array.Sort(ss);
        Array.Sort(tt);
        
        return new string(ss) == new string(tt);
    }
}