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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null)
        {
            return new TreeNode(val);
        }
        
        if(root.val > val)
        {
            root.left = InsertIntoBST(root.left, val);
        }
        else
        {
            root.right = InsertIntoBST(root.right, val);
        }
        return root;
    }
    // public TreeNode InsertIntoBST(TreeNode root, int val) {
    //     if(root == null)
    //         return new TreeNode(val);

    //     TreeNode current = root;

    //     while(true)
    //     {
    //         if(current.val > val)
    //         {
    //             if(current.left == null)
    //             {
    //                 current.left = new TreeNode(val);
    //                 break;
    //             }
                
    //             current = current.left;
    //         }
    //         else
    //         {
    //             if(current.right == null)
    //             {
    //                 current.right = new TreeNode(val);
    //                 break;
    //             }
                
    //             current = current.right;
    //         }
    //     }
    //     return root;
    // }
}