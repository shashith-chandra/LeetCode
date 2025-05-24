public class Solution {
    public int ShipWithinDays(int[] weights, int days) {

        int min = 0, max = 0, result = 0;
        foreach(var weight in weights)
        {
            min = Math.Max(min, weight);
            max += weight;
        }
        while(min<=max)
        {
            int mid = min+(max-min)/2;
            if(isShippingPossible(weights, mid, days))
            {
                max = mid-1;
                result = mid;
            }
            else
            {
                min = mid+1;
            }
        }

        return result;

    }

    private bool isShippingPossible(int[] weights, int capacity, int days)
    {
       int currentCap = capacity;

       foreach(var weight in weights)
       {
        if(currentCap - weight >= 0)
        {
            currentCap -= weight;
        }
        else
        {
            days--;
            currentCap = capacity-weight;
        }
       }
       return days>0;
    }
}