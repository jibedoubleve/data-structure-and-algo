using System.Net;

namespace DataStructureAndAlgo.Tests;

public class Helpers
{
    public static int[] BuildArray(int size)
    {
        var result = new List<int>();
        for (var i = 0; i < size; i++) result.Add(i);
        return result.ToArray();
    }

    public static List<int>[] TreeFromString(string graph)
    {
        var lines = graph.Split(Environment.NewLine);
        var result = new List<int>[lines.Length];
        for (var i = 0; i < result.Length; i++) result[i] = new();
        
        for (var i = 0; i < lines.Length; i++)
        {
            var line = lines[i];
            var references = line.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            foreach (var reference in references)
            {
                result[i].Add(int.Parse(reference));
            }
        }

        return result;
    }
}