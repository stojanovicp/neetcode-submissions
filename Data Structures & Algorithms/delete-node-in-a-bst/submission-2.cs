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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null)
            return null;
        
        if(root.val == key)
        {
            if(root.left == null && root.right == null)
                return null;
            
            if(root.left != null && root.right != null)
            {
                TreeNode newRoot = root.right;
                while(newRoot.left != null)
                    newRoot = newRoot.left;

                root.right = DeleteNode(root.right, newRoot.val);
                root.val = newRoot.val;

                return root;
            }

            return root.left ?? root.right;
        }
        
        if(root.val > key)
        {
            root.left = DeleteNode(root.left, key);
        }
        else
        {
            root.right = DeleteNode(root.right, key);
        }

        return root;
    }
}