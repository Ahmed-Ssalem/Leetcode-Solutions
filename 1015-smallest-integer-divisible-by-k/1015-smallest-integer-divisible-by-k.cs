public class Solution {
    public int SmallestRepunitDivByK(int k) {
         
        if (k % 2 == 0 || k % 5 == 0) return -1;
        int n = 1;
        int res = 1;
        while (true)
        {
            if (n % k == 0)
                return res;
            n = ((n * 10) + 1) % k;
            ++res;
        }
    }
}