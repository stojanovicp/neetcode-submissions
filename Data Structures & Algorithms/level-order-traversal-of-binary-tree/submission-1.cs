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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> result = new();

        if(root == null)
            return result;

        Queue<TreeNode> queue = new();

        queue.Enqueue(root);
        

        while(queue.Count > 0)
        {
            int levelSize = queue.Count;
            List<int> levelList = new();

            for(int i = 0; i < levelSize; i++)
            {
                TreeNode current = queue.Dequeue();
                levelList.Add(current.val);
                if(current.left != null) queue.Enqueue(current.left);
                if(current.right != null) queue.Enqueue(current.right);
            }
            result.Add(levelList);
        }

        return result;
    }
}

