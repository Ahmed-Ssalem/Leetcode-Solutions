public class Solution {
    public int Compress(char[] chars) {
        
        if (chars.Length == 1)
            return 1;

        int pointer = 0, charCount = 1;
        var currentChar = chars[0];

        for (int i = 1; i < chars.Length; ++i)
        {
            if (currentChar == chars[i])
                charCount++;
            else
            {
                chars[pointer++] = currentChar;
                
                if (charCount > 1)
                    foreach (var ch in charCount.ToString())
                        chars[pointer++] = ch;
                
                currentChar = chars[i];
                charCount = 1;
            }
        }

        chars[pointer++] = currentChar;
                
        if (charCount > 1)
            foreach (var ch in charCount.ToString())
                chars[pointer++] = ch;

        return pointer;     
    }
}