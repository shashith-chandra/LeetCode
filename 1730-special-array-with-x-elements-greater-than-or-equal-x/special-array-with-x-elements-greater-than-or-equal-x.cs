public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);
        for(int i = nums.Length-1; i >=0; i--)
        {
            int val = nums.Length - i;
            if((nums[i]>= val) &&(i == 0 || nums[i-1] < val))
            {
                return val;
            }
        }
        return -1;
    }
}