public class Solution {
    public int MaximumCandies(int[] candies, long k) {
        int maxCandiesInPile = 0;
        for (int i = 0; i < candies.Length; i++) {
            maxCandiesInPile = Math.Max(maxCandiesInPile, candies[i]);
        }

        int left = 0;
        int right = maxCandiesInPile;
       
       while(left<right)
       {
        int mid = (left+right+1)/2;
        if(canAllocateCandies(candies, k, mid))
        {
            left = mid;
        }
        else
        {
            right = mid - 1;
        }
       }
        return left;
    }
        private bool canAllocateCandies(int[] candies, long k, int numOfCandies) 
        {
        long maxNumOfChildren = 0;
        for (int pileIndex = 0; pileIndex < candies.Length; pileIndex++) {
            maxNumOfChildren += candies[pileIndex] / numOfCandies;
        }

        return maxNumOfChildren >= k;
    }
    
}