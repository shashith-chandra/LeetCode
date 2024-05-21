public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0, j = i+1; 
        while(j<= nums.Length - 1)
        {
            if(nums[i] != nums[j])
            {
                i++;
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            j++;
        }
        return i+1;
    }
}