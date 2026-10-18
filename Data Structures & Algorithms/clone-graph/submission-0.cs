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
        return DFS(new Dictionary<Node,Node>(), node);
    }
    private Node DFS(Dictionary<Node,Node> map, Node node)
    {
        if(node == null)
            return null;

        if(map.ContainsKey(node))
            return map[node];

        var copy = new Node(node.val);
        map[node] = copy;

        foreach (var neighbor in node.neighbors)
        {
            var clonedNeighbor = DFS(map, neighbor);
            copy.neighbors.Add(clonedNeighbor);
        }

        return copy;
    }
}
