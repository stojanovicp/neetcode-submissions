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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null)
            return false;

        if(targetSum == root.val && root.left == null && root.right == null)
            return true;

        if(HasPathSum(root.left, targetSum - root.val))
            return true;

        if(HasPathSum(root.right, targetSum - root.val))
            return true;
            
        return false;
    }
}