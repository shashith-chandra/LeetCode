public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> restValues = new Dictionary<int, int>();
        for(int i=0; i< nums.Length; i++)
        {
            int remVal = target - nums[i];
            if(restValues.ContainsKey(remVal))
            {
                return new int[]{restValues[remVal], i};
            }
            restValues[nums[i]] = i;
        }
        return new int[0];
    }
}