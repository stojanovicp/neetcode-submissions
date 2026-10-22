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
    public List<int> RightSideView(TreeNode root) {
        List<int> result = new();
        
        DFS(root, 0, result);

        return result;
    }
    private void DFS(TreeNode node, int depth, List<int> list)
    {
        if(node == null)
            return;
        
        if (depth == list.Count)
            list.Add(node.val);

        DFS(node.right, depth + 1, list);
        DFS(node.left, depth + 1, list);
    }
}
