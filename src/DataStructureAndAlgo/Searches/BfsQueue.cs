namespace DataStructureAndAlgo.Searches;

public static class BfsQueue
{
    public static void Explore(IReadOnlyList<List<int>> graph, Action<int> handler) => Explore(graph, 0, handler);
    private static void Explore(IReadOnlyList<List<int>> graph,int index, Action<int> handler)
    {
        var marked = new bool[graph.Count];
        var queue = new Queue<int>();
        queue.Enqueue(index);
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (marked[current]) continue;

            marked[current] = true;
            handler(current);

            foreach (var i in graph[current])
            {
                if (marked[i]) continue;

                queue.Enqueue(i);
            }
        }
    }
}