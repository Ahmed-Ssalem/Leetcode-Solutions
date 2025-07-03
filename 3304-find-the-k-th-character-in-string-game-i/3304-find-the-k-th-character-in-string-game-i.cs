public class Solution {
    public char KthCharacter(int k) {

        List<char> chars = new List<char> {'a'};

        while (chars.Count < k)
        {
            int currentLength = chars.Count;
            for (int i = 0; i < currentLength; i++)
                chars.Add((char)('a' + (chars[i] - 'a' + 1) % 26));
            
        }
        
        return chars[k-1];
    }
}