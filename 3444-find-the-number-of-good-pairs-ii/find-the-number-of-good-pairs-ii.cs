public class Solution {
    public long NumberOfPairs(int[] nums1, int[] nums2, int k) {
        Dictionary<int,int> map = new();
        //Add all factors of nums1 to map with their count
        foreach(int num in nums1)
        {
            for(int i=1; i*i<=num; i++)
            {
                if(i*i==num)
                {
                    if(map.ContainsKey(i)) map[i]++;
                    else map[i]=1;
                }
                else if(num%i==0)
                {
                    if(map.ContainsKey(i)) map[i]++;
                    else map[i]=1;
                    if(map.ContainsKey(num/i)) map[num/i]++;
                    else map[num/i]=1;
                }
            }
        }
        long result=0;
        foreach(int num in nums2)
        {
            if(map.ContainsKey(num*k)) result+=map[num*k];
        }
        return result;
    }
}