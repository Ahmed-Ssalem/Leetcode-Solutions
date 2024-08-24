public class Solution {
    public int XorOperation(int n, int start) {
        int res = 0, i = 0;
        while (n > 0){
            int nums = start + (2 * i);
            res ^= nums;
            ++i;
            --n;
        }
        return res;
    }
}