/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums.Length == 0) return null;
        if(nums.Length == 1) return new TreeNode(nums[0], null, null);
        var mid = nums.Length/2;
        return new TreeNode(nums[mid],
        SortedArrayToBST(nums.Take(mid).ToArray()),
        SortedArrayToBST(nums.Skip(mid+1).ToArray()));

    }
}