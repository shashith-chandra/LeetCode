public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int ans = numBottles;
        while(numBottles >= numExchange)
        {
            int refill = numBottles / numExchange;
            ans += refill;
            int empty = numBottles % numExchange;
            numBottles = refill + empty;
        }
        return ans;
    }
}