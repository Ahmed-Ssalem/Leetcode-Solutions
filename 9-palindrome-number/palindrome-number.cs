public class Solution {
    public bool IsPalindrome(int x) {
        
        int num = x, reversedNum = 0;

        if (num < 0 || num > 0 && num % 10 == 0)
            return false;
        else if (num == 0)
            return true;
        else{
            while ( num > 0){
                int reminder = num % 10;
                reversedNum =  (reversedNum * 10) + reminder;
                num /= 10;
            }
        }
        return x == reversedNum ? true : false;
    }
}