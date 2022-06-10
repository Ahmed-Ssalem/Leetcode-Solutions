public class Solution {
    public int LengthOfLongestSubstring(string s) {

        var maxSize = 0;        
        List<char> letters = new List<char>();
        
        foreach (char c in s){
            if (!letters.Contains(c)){
                letters.Add(c);
            }
            else{
                maxSize = Math.Max(maxSize, letters.Count);
                var indx = letters.IndexOf(c);
                letters.RemoveRange(0, indx + 1);
                letters.Add(c);
            }
        }
        return Math.Max(maxSize, letters.Count);
    }
}