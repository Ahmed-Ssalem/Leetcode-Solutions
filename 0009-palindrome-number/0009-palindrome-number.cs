public class Solution {
    public bool IsPalindrome(int x) {
        
        string num = x.ToString();
        int len = num.Length;

        for (int i = 0, j = len - 1; i < (len / 2) && j >= (len / 2); ++i, --j)
            if (num[i] != num[j])
            {
                return false;
                break;
            }
        return true;        
    }
}