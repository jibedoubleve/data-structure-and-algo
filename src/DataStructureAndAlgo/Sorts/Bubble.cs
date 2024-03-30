namespace DataStructureAndAlgo.Sorts;

public abstract class Bubble
{
    public static void Sort(int[] vector)
    {
        for (var i = vector.Length - 1; i >= 0; i--)
        for (var j = 0; j < i; j++)
            if (vector[j] > vector[j + 1])
                (vector[j], vector[j + 1]) = (vector[j + 1], vector[j]);
    }
}