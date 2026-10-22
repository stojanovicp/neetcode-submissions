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
    private int height = 0;
    public List<int> RightSideView(TreeNode root) {
        List<int> result = new();
        
        DFS(root, 1, result);

        return result;
    }
    private void DFS(TreeNode root, int currHeight, List<int> list)
    {
        if(root == null)
            return;
        
        if(currHeight > height)
        {
            list.Add(root.val);
            height++;
        }
        DFS(root.right, currHeight + 1, list);
        DFS(root.left, currHeight + 1, list);
    }
}
