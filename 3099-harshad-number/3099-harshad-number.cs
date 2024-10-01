public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        
        int num = x, res = 0;
        
        while (num > 0)
        {
            res += num % 10;
            num /= 10;
        }

        return x % res == 0 ? res : -1;
    }
}