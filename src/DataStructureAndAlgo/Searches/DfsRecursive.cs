namespace DataStructureAndAlgo.Searches;

public static class DfsRecursive
{
    public static void Explore(IReadOnlyList<List<int>> graph, Action<int> handler)
    {
        var visitRegistry = new bool[graph.Count];
        Explore(graph, 0, handler, visitRegistry);
    }

    private static void Explore(IReadOnlyList<List<int>> graph, int index, Action<int> handler, bool[] visitRegistry)
    {
        var nodes = graph[index];
        visitRegistry[index] = true;
        handler(index);

        foreach (var current in nodes)
            if (visitRegistry[current] == false)
                Explore(graph, current, handler, visitRegistry);
    }
}