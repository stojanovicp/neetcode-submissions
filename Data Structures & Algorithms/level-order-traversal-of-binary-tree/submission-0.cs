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
        if(root == null)
            return [];
        var result = new List<List<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            var level = new List<int>();
            int levelCounter = queue.Count;
            for(int i=0; i < levelCounter; i++)
            {
                var curr = queue.Dequeue();
                if(curr.left != null)
                    queue.Enqueue(curr.left);
                if(curr.right != null)
                    queue.Enqueue(curr.right);
                level.Add(curr.val);
            }
            result.Add(level);
        }

        return result;
    }
}
