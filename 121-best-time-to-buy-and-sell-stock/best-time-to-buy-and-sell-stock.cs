public class Solution {
    public int MaxProfit(int[] prices) {
        var min = prices[0];
        var profit = 0;
        foreach (var today in prices) {
            profit = Math.Max(profit, today-min);
            min = Math.Min(min, today);
        }
        return profit;
    }
}