namespace DataStructureAndAlgo.Sorts;

public static class QuickSort
{
    public static int[] Sort(int[] array)
    {
        if (array.Length < 1) return array;

        var pivot = array[^1];
        var small = new List<int>();
        var great = new List<int>();

        for (var i = 0; i < array.Length - 1; i++)
            if (array[i] < pivot) small.Add(array[i]);
            else great.Add(array[i]);

        var left = Sort(small.ToArray());
        var right = Sort(great.ToArray());

        return left.Concat(new[] { pivot })
                   .Concat(right)
                   .ToArray();
    }
}