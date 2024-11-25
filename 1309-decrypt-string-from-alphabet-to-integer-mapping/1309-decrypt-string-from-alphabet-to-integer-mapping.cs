public class Solution {
    public string FreqAlphabets(string s) {

        var chars = new List<char>();

        for (int i = s.Length - 1; i >= 0; --i) {
            if (s[i] == '#') 
            {
                var num = (s[i - 1] - '0') + ((s[i - 2] - '0') * 10);
                chars.Add((char)(num + 96));
                i -= 2;
            } 
            else 
                chars.Add((char)((s[i] - '0') + 96));
        }
        return string.Concat(chars.AsEnumerable().Reverse());
    }
}
