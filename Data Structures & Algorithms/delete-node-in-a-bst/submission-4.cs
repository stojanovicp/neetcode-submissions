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
    //recusrsion
    // public TreeNode DeleteNode(TreeNode root, int key) {
    //     if(root == null)
    //         return null;
        
    //     if(root.val == key)
    //     {   
    //         if(root.left != null && root.right != null)
    //         {
    //             TreeNode successor = root.right;
    //             while(successor.left != null)
    //                 successor = successor.left;

    //             root.right = DeleteNode(root.right, successor.val);
    //             root.val = successor.val;

    //             return root;
    //         }

    //         return root.left ?? root.right;
    //     }
        
    //     if(root.val > key)
    //     {
    //         root.left = DeleteNode(root.left, key);
    //     }
    //     else
    //     {
    //         root.right = DeleteNode(root.right, key);
    //     }

    //     return root;
    // }
    //iterative
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null)
            return null;

        TreeNode parent = null;
        TreeNode current = root;

        while(current != null && current.val != key)
        {
            parent = current;

            if(current.val < key)
                current = current.right;
            else
                current = current.left;
        }

        if(current == null)
            return root;

        if(current.right != null && current.left != null)
        {
            TreeNode successorParent = current;
            TreeNode successor = current.right;

            while(successor.left != null)
            {
                successorParent = successor;
                successor = successor.left;
            }
            if(successorParent != current)
                successorParent.left = successor.right;
            else
                successorParent.right = successor.right;

            current.val = successor.val;
        }
        else
        {
            TreeNode replacement = current.left ?? current.right;

            if(parent == null)
            {
                return replacement;
            }

            if(parent.left == current)
                parent.left = replacement;
            else
                parent.right = replacement;
        }
        return root;
    }
}