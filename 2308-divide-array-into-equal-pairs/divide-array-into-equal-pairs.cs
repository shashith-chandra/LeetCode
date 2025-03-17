public class Solution {
    public bool DivideArray(int[] nums) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach(var item in nums)
        {
            if(!freq.ContainsKey(item))
            {
                freq.Add(item, 1);
            }
            else
            {
                freq[item]++;
            }
        }
        return freq.Where(x=>x.Value%2 != 0).Count() == 0;
        
    }
}