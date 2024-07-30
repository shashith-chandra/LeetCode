public class Solution {
    public void MoveZeroes(int[] nums) {
       int i = 0, j = 1;
       while (i < nums.Length && j < nums.Length && i < j)
       {
        if(nums[i] != 0)
        {
            i++;
            j++;
        }
        else if(nums[i] == 0 && nums[j] == 0){ j++; }
        else if(nums[i] == 0 && nums[j] != 0)
        {
            nums[i] = nums[j];
            nums[j] = 0;
            i++;
            j++;
        }
        if(i>=j)
        {
            j = i+1;
        }
       }
        
    }
}