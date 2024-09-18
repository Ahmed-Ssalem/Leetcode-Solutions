public class Solution {
    public int CountDigits(int num) {
        
        int n = num, res = 0;

        while (num > 0){
            var rightNum = num % 10;
            if (n % rightNum == 0)
                res++;
            num /= 10;
        }
        return res;
    }
}