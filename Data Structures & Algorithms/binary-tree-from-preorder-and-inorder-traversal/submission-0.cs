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
    int preIndex;
    Dictionary<int, int> inorderIndex;
    int[] preorder;

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        this.preorder = preorder;
        preIndex = 0;

        inorderIndex = new Dictionary<int, int>();
        for(int i = 0; i < inorder.Length; i++)
            inorderIndex[inorder[i]] = i;

        return BuildSubtree(0, inorder.Length - 1);
    }
    private TreeNode BuildSubtree(int inLeft, int inRight)
    {
        if(inLeft > inRight)
            return null;
        
        TreeNode root = new TreeNode(preorder[preIndex]);
        preIndex ++;

        int index = inorderIndex[root.val];

        root.left = BuildSubtree(inLeft, index-1);
        root.right = BuildSubtree(index+1, inRight);

        return root;
    }
}
