public class Solution {
    public int LengthOfLastWord(string s) {

         int pointer = 0, len = 0;

        for (int i = s.Length - 1; i >= 0; --i)
            if (s[i] != ' '){ 
                pointer = i;
                break;
             }

        for (int i = pointer; i >= 0; --i){
            if (s[i] != ' ') 
                len++;
            else
                break;
        }    
             
        return len;

        
        /*
        string[] split = s.Split(new char [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return split[split.Length - 1].Length;
        */
    }
}