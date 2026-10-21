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
    public bool IsBalanced(TreeNode root) {
        var result = GetHeight(root);
        return result.balanced;
    }

    private (int height, bool balanced) GetHeight(TreeNode root) {
        if(root == null)
            return (0,true);

        var left = GetHeight(root.left);
        var right = GetHeight(root.right);

        bool balanced = left.balanced && right.balanced && Math.Abs(left.height - right.height) <= 1;

        int height = 1 + Math.Max(left.height, right.height);

        return (height, balanced);
    }
}
