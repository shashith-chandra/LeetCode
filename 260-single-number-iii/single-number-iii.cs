public class Solution {
    public int[] SingleNumber(int[] nums) {
        int xor = 0;
        foreach(int num in nums) xor ^= num;
        int diffBit = xor & -xor;

        int first = 0;
        foreach(int num in nums)
        {
            if((num & diffBit) != 0)
            {
                first ^= num;
            }
        }
        return new int[]{ first, xor^first};
    }
}