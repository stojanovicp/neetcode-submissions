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
        if(root == null)
            return new List<int>();
            
        var queue = new Queue<TreeNode>();
        var result = new List<int>();

        queue.Enqueue(root);
        
        while(queue.Count > 0)
        {
            int right = -1;
            int levelCounter = queue.Count;

            for(int i=0; i < levelCounter; i++)
            {
                var curr = queue.Dequeue();
                if(curr.left != null)
                    queue.Enqueue(curr.left);
                if(curr.right != null)
                    queue.Enqueue(curr.right);
                right = curr.val;
            }

            result.Add(right);
        }

        return result;
    }
}
