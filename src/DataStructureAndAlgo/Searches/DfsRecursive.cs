namespace DataStructureAndAlgo.Searches;

public static class DfsRecursive
{
    public static void Explore(IReadOnlyList<List<int>> graph, Action<int> handler)
    {
        var marked = new bool[graph.Count];
        Explore(graph, 0, handler, marked);
    }

    private static void Explore(IReadOnlyList<List<int>> graph, int index, Action<int> handler, bool[] marked)
    {
        var nodes = graph[index];
        marked[index] = true;
        handler(index);

        foreach (var current in nodes)
            if (marked[current] == false)
                Explore(graph, current, handler, marked);
    }
}