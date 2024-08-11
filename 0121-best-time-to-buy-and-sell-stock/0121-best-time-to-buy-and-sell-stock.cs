public class Solution {
    public int MaxProfit(int[] prices) {

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (var price in prices){
            
            if (price < minPrice)
                minPrice = price;
            
            var potentialProfit = price - minPrice;
            
            if (potentialProfit > maxProfit)
                maxProfit = potentialProfit;
        }
        return maxProfit;
    }
}