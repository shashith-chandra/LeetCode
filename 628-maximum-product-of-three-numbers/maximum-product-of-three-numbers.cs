public class Solution {
    public int MaximumProduct(int[] nums) {

        Array.Sort(nums);

        return Math.Max(nums[nums.Length - 1] * nums[nums.Length - 2] * 
                                                    nums[nums.Length - 3], 
                            nums[nums.Length - 1] * nums[0] * nums[1]);
    }
}