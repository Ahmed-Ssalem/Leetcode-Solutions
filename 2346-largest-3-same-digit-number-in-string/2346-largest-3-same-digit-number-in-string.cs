public class Solution {
    public string LargestGoodInteger(string num) {
        
        char res = ' ';

        for (int i = 0; i < num.Length - 2; ++i)
            if (num[i] == num[i+1] && num[i+1] == num[i+2] && num[i] > res)
                res = num[i];
        
        return res == ' ' ? "" : new string(res, 3);
    }
}