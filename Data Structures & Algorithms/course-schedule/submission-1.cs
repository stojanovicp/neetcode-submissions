public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<int>[] graph = new List<int>[numCourses];
        int[] states = new int[numCourses];

        for(int i = 0; i < numCourses; i++)
        {
            graph[i] = new List<int>();
        }
        foreach(int[] pair in prerequisites)
        {
            graph[pair[0]].Add(pair[1]);
        }

        for (int course = 0; course < numCourses; course++)
        {
            if (HasCycle(graph, course, states))
                return false;
        }
        
        return true;
    }

    private bool HasCycle(List<int>[] graph, int index, int[] states)
    {
        if(states[index] == 1)
            return true;
        
        if (states[index] == 2)
            return false;

        states[index] = 1;

        foreach (int prerequisite in graph[index])
        {
            if (HasCycle(graph, prerequisite, states))
                return true;
        }

        states[index] = 2;

        return false;
    }
}
