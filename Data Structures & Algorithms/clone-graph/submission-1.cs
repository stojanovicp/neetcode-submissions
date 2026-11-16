/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null)
            return null;

        return CloneGraphDFS(node, new Dictionary<Node,Node>());
    }

    private Node CloneGraphDFS(Node original, Dictionary<Node, Node> memo)
    {
        if(memo.ContainsKey(original))
        {
            return memo[original];
        }

        Node newNode = new Node(original.val);
        memo[original] = newNode;

        foreach(Node neighbor in original.neighbors)
        {
            newNode.neighbors.Add(CloneGraphDFS(neighbor, memo));
        }

        return newNode;
    }
}
