public class Solution {
    public int MinCapability(int[] nums, int k) {
        // int[] temp = nums;
        // Array.Sort(temp);
        // int first = 0, second = 1;
        // while(Math.Abs(Array.IndexOf(nums,temp[first]) - Array.IndexOf(nums, temp[second])) == 1 && second < nums.Length)
        // {
        //     second++;
        // }
        // return Math.Max(temp[first], temp[second]);

        int minReward = 1;
        int maxReward = nums.Max();;
        int totalHouses = nums.Length;

        // Use binary search to find the minimum reward possible.
        while (minReward < maxReward) {
            int midReward = (minReward + maxReward) / 2;
            int possibleThefts = 0;

            for (int index = 0; index < totalHouses; ++index) {
                if (nums[index] <= midReward) {
                    possibleThefts += 1;
                    index++; // Skip the next house to maintain the
                    // non-adjacent condition
                }
            }

            if (possibleThefts >= k) maxReward = midReward;
            else minReward = midReward + 1;
        }

        return minReward;

    }
}