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
    private int preorderIndex = 0;

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        Dictionary<int,int> inorderIndices = new();
        for(int i = 0; i < inorder.Length; i++)
        {
            inorderIndices[inorder[i]] = i;
        }
        return Build(preorder, 0, inorder.Length - 1, inorderIndices);
    }

    private TreeNode Build(int[] preorder, int left, int right, Dictionary<int,int> inorderIndices)
    {
        if (left > right)
            return null;
            
        TreeNode root = new TreeNode(preorder[preorderIndex]);
        preorderIndex++;

        int rootIndex = inorderIndices[root.val];

        root.left = Build(preorder, left, rootIndex - 1, inorderIndices);
        root.right = Build(preorder, rootIndex + 1, right, inorderIndices);

        return root;
    }
}

