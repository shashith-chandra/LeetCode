public class Solution {
    public int MaximumCount(int[] nums) {
        int pos = 0, neg = 0;
        foreach(var item in nums)
        {
            if(item > 0)
            {
                pos++;
            }
            else if(item<0)
            {
                neg++;
            }
        }
        return Math.Max(pos, neg);
        
    }
}