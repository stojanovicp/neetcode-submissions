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
    // public List<int> InorderTraversal(TreeNode root) {
    //     List<int> result = new();

    //     Inorder(root, result);

    //     return result;
    // }
    // private void Inorder(TreeNode root, List<int> list)
    // {
    //     if(root == null)
    //         return;

    //     Inorder(root.left, list);
    //     list.Add(root.val);
    //     Inorder(root.right, list);
    // }
    public List<int> InorderTraversal(TreeNode root) {
        List<int> result = new();

        if (root == null)
            return result;

        Stack<TreeNode> stack = new();

        TreeNode current = root;

        while(current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }
            current = stack.Pop();
            result.Add(current.val);
            current = current.right;
        }

        return result;
    }
}