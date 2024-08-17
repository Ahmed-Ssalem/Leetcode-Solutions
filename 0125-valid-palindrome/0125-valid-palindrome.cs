public class Solution {
    public bool IsPalindrome(string s) {

        StringBuilder str = new StringBuilder();
        
        foreach (char c in s)
            if (char.IsLetterOrDigit(c)) 
                str.Append(c);

        var res = str.ToString().ToLower(); 
        
        var pointer = res.Length - 1;
        var isValid = true; 

        for (int i = 0; i < res.Length / 2; ++i){
            if (res[i] != res[pointer]){
                isValid = false;
                break;
            }
            --pointer;
        }
        return isValid ? true : false;
    }
}