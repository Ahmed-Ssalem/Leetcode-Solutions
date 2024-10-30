public class Solution {
    public string RemoveStars(string s) {
        
        var chars = new Stack<char>();
        
        foreach (var c in s)
        {
            if (c == '*')
                chars.Pop();
            else
                chars.Push(c);
        }

        return new string(chars.Reverse().ToArray());
    }
}