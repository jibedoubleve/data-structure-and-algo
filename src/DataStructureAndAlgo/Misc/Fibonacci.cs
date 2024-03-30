using System.Net;
using System.Runtime.InteropServices;

namespace DataStructureAndAlgo.Misc;

public static class Fibonacci
{
    public static IEnumerable<int> SequenceStack(int length)
    {
        var sequence = new Stack<int>();
        sequence.Push(0);
        sequence.Push(1);

        for (var _ = 0; _ < length; _++)
        {
            var second = sequence.Pop();
            var first = sequence.Pop();
            //--
            var third = first + second;

            sequence.Push(first);
            sequence.Push(second);
            sequence.Push(third);
        }

        return sequence.ToArray().Reverse();
    }

    public static IEnumerable<int> SequenceRecursive(int length)
    {
        var list = new List<int> { 0, 1 };
        Calculate(ref list, length - 2, 0);
        return list;
    }

    private static void Calculate(ref List<int> list, int maxDepth, int currentDepth)
    {
        var left = list.ElementAt(list.Count - 2);
        var right = list.Last();
        var sum = left + right;
        
        list.Add(sum);
        if (maxDepth >= currentDepth)
            Calculate(ref list, maxDepth, ++currentDepth);
    }
}