// public class Solution {
//     public IList<IList<int>> ThreeSum(int[] nums) {
//         IList<IList<int>> ans = new List<IList<int>>();
//         Hashtable<List<int>> usedVal = new Hashtable<List<int>>();
//        Array.Sort(nums);
       
//         if(nums.Length <3) return ans;
//         if(nums.Length == 3 && (nums[0] + nums[1] + nums[2]) == 0)
//         {
//             List<int> l1 = new List<int>{nums[0], nums[1], nums[2]};
//             ans.Add(l1);
//            return ans;
//         }

//         for(int i = 0; i< nums.Length; i++)
//         {
//             for(int j = 0; j< nums.Length; j++)
//             {
//                 if(i == j) continue;
                
//             }
//         }
//         return ans;
//     }
// }
using System;
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue; // Skip duplicate values for i
            }
            int j = i + 1, k = nums.Length - 1;
            while (j < k) {
                int sum = nums[i] + nums[j] + nums[k];
                if (sum == 0) {
                    result.Add(new List<int>{nums[i], nums[j], nums[k]});
                    j++;
                    k--;
                    while (j < k && nums[j] == nums[j - 1]) j++;
                    while (j < k && nums[k] == nums[k + 1]) k--;
                } else if (sum < 0) {
                    j++;
                } else {
                    k--;
                }
            }
        }
        
        return result;
    }
}