public class Solution {
    public int[] FinalPrices(int[] prices) {
        
        int len = prices.Length;
        int[] res = new int[len];
        res[len-1] = prices[len-1];
        
        for (int i = 0; i < len-1; ++i)
            for (int j = i+1; j < len; ++j)
                if (prices[j] <= prices[i]){
                    res[i] = prices[i] - prices[j];
                    break;
                }
                else
                    res[i] = prices[i];
        return res;
    }
}