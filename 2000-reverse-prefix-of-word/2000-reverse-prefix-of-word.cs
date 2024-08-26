public class Solution {
    public string ReversePrefix(string word, char ch) {
        
        int indx = 0;

        for (int i = 0; i < word.Length; ++i)
            if (word[i] == ch){
                indx = i;
                break;
            }
        
        int len = (indx + 1) / 2;
        char[] charArray = word.ToCharArray();

        for (int i = 0; i < len; ++i){
            var temp = charArray[indx];
            charArray[indx] = charArray[i];
            charArray[i] = temp;
            --indx;
        }

        return new string(charArray);
    }
}