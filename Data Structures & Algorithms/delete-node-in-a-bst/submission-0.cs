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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null)
            return null;

        if(root.val > key)
        {
            root.left = DeleteNode(root.left, key);
        }
        else if(root.val < key)
        {
            root.right = DeleteNode(root.right, key);
        }
        else if(root.val == key)
        {
            if(root.left == null && root.right == null)
            {
                return null;
            }
            else if(root.left == null)
            {
                return root.right;
            }
            else if(root.right == null)
            {
                return root.left;
            }
            else
            {
                TreeNode newNode = new TreeNode(FindMinNode(root.right));
                newNode.left = root.left;
                newNode.right = DeleteNode(root.right, newNode.val);
                return newNode;
            }
        }
        return root;
    }
    private int FindMinNode(TreeNode curr)
    {
        while(curr != null && curr.left != null)
            curr = curr.left;
        return curr.val;
    }
}