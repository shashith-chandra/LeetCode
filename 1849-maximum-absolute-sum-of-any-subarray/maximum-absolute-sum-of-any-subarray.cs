public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        int maxPrefixSum = 0, minPrefixSum = 0, prefixSum = 0;
        foreach(var item in nums)
        {
            prefixSum += item;
            minPrefixSum = Math.Min(prefixSum, minPrefixSum);
            maxPrefixSum = Math.Max(prefixSum, maxPrefixSum);
        }
        
        return Math.Abs(maxPrefixSum - minPrefixSum);
    }
}