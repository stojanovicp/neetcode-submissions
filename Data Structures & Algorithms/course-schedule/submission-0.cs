public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var graph = new Dictionary<int, List<int>>();

        foreach(var p in prerequisites)
        {
            if(!graph.ContainsKey(p[1]))
                graph[p[1]] = new List<int>();

            graph[p[1]].Add(p[0]);

            if(!graph.ContainsKey(p[0]))
                graph[p[0]] = new List<int>();
        }

        var visiting = new HashSet<int>();
        var visited = new HashSet<int>();

        foreach(var p in prerequisites)
        {
            if(!DFS(graph, p[1], visiting, visited))
                return false;
        }

        return true;
    }
    private bool DFS(Dictionary<int, List<int>> map,int curr, HashSet<int> visiting, HashSet<int> visited)
    {
        if(visiting.Contains(curr))
            return false;

        if(visited.Contains(curr))
            return true;
        
        visiting.Add(curr);

        foreach(int n in map[curr])
        {
            if (!DFS(map, n, visiting, visited))
                return false;
        }

        visiting.Remove(curr);
        visited.Add(curr);

        return true;
    }
}
