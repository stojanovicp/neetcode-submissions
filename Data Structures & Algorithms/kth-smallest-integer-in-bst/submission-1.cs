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
    public int KthSmallest(TreeNode root, int k) {
        int count = 0;
        int result = -1;
        Inorder(root, ref count, k, ref result);
        return result;
    }

    private void Inorder(TreeNode root, ref int count, int k, ref int result)
    {
        if (root == null)
            return;

        Inorder(root.left, ref count, k, ref result);

        count++;
        if (count == k)
        {
            result = root.val;
            return;
        }

        Inorder(root.right, ref count, k, ref result);
    }

}
