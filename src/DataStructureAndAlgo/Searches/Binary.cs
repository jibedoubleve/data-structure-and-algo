namespace DataStructureAndAlgo.Searches;

public static class Binary
{
    public static int? Search(IReadOnlyList<int> orderedVector, int find)
    {
        var start = 0;
        var end = orderedVector.Count - 1;
        var mid = end / 2;
        while (start <= end)
        {
            if (find == orderedVector[mid]) return mid;

            if (find > orderedVector[mid]) start = mid + 1;
            else end = mid - 1;

            mid = start + (end - start) / 2;
        }

        return null; // not found
    }
}