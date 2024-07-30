public class Solution {
    public int MissingNumber(int[] nums) {
        int xor1 = 0, xor2 = 0, n = nums.Length - 1;
        for(int i = 0; i<= n; i++)
        {
            xor2 = xor2^ nums[i];
            xor1 = xor1 ^ i;
        }
        xor1 = xor1 ^ nums.Length;
        return xor1^xor2;        
    }
}