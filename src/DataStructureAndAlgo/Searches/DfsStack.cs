namespace DataStructureAndAlgo.Searches;

public abstract class DfsStack
{
    public static void Explore(IReadOnlyList<List<int>> graph, Action<int> handler) => Explore(graph, 0, handler);
    private static void Explore(IReadOnlyList<List<int>> graph, int index, Action<int> handler)
    {
        var marked = new bool[graph.Count];
        var stack = new Stack<int>();
        stack.Push(index);
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if(marked[current]) continue;
            
            marked[current] = true;
            handler(current);

            foreach (var i in graph[current])
            {
                if (marked[i]) continue;

                stack.Push(i);
            }
        }
    }
}