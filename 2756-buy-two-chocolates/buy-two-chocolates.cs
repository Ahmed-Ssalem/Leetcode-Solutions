public class Solution {
    public int BuyChoco(int[] prices, int money) {
        
        Array.Sort(prices);
        int sum = prices[0] + prices[1];
        return sum <= money ? money - sum : money;
    }
}