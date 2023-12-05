public class Solution {
    public int NumberOfMatches(int n) {
        int res = 0;
        if (n == 1)
            return 0;
        else{
            while (n >= 2){
                if (n % 2 == 0){
                    res += n/2;
                    n /= 2;
                }
                else{
                    res += 1 + (n/2);
                    n = (n-1) / 2;
                }
            }
        }
        return res;
    }
}