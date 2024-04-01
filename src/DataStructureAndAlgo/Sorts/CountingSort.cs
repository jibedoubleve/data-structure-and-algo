namespace DataStructureAndAlgo.Sorts;

public class CountingSort
{
    public static int[] Sort(int[] array)
    {
        var max = 0;
        foreach (var item in array)
            if (item > max)
                max = item;

        var counter = new int[max + 1];

        foreach (var item in array) counter[item]++;

        var list = new List<int>();
        for (var i = 0; i < counter.Length; i++)
        for (var j = 0; j <counter[i]; j++)
            list.Add(i);

        return list.ToArray();
    }
}