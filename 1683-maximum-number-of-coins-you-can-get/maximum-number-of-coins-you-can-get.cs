public class Solution {
    public int MaxCoins(int[] piles) {
        
        Array.Sort(piles);
        int len = piles.Length, res = 0;
        
        for (int i = len-2, steps = len/3; i >= 0 && steps > 0; i-=2, --steps)
            res += piles[i];
        
        return res;
    }
}