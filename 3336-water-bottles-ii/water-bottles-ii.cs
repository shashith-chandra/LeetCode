public class Solution {
    public int MaxBottlesDrunk(int numBottles, int numExchange){
        int drank = numBottles, empty = numBottles, full = 0;
        while(empty >= numExchange)
        {
            while(empty >= numExchange)
            {
                empty -= numExchange;
                full++;
                numExchange++;
            }
                drank += full;
                empty += full;
                full = 0;
            
        }
        return drank;

    }
}