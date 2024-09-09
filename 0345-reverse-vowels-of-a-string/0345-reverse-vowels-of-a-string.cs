public class Solution {
    public string ReverseVowels(string s) {
        
        List<int> v = new List<int>();
        char[] c = s.ToCharArray(); 

        for (int i = 0; i < s.Length; ++i)
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' ||
                s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                v.Add(i);
        
        
        for (int i = 0, len = v.Count - 1; i < v.Count / 2; ++i, --len){
            var temp = c[v[i]];
            c[v[i]] = c[v[len]];
            c[v[len]] = temp;
        }

        return new string(c);
    }
}