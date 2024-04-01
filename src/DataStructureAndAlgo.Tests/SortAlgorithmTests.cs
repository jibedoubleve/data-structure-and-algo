using DataStructureAndAlgo.Sorts;
using FluentAssertions;
using Xunit;

namespace DataStructureAndAlgo.Tests;

public class SortAlgorithmTests
{
    
    [Theory,
     InlineData(new[] { 1, 5, 4, 2, 3, 6, 9, 8, 10, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
     InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
     InlineData(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
     InlineData(new[] { 1, 5, 4, 2, 3, 11, 6, 9, 8, 10, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
     InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
     InlineData(new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
    public void BubbleSort(int[] array, IEnumerable<int> sorted)
    {
        Bubble.Sort(array);
        array.Should().Equal(sorted);
    }
    
    [Theory,
     InlineData(new[] { 1, 5, 4, 2, 3, 6, 9, 8, 10, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
     InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
     InlineData(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
     InlineData(new[] { 1, 5, 4, 2, 3, 11, 6, 9, 8, 10, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
     InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
     InlineData(new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
    public void QuickSort(int[] array, IEnumerable<int> sorted)
    {
        Sorts.QuickSort
             .Sort(array)
             .Should().Equal(sorted);
    }
    
    [Theory,
     InlineData(new[] { 1, 5, 4, 2, 3, 6, 9, 8, 10, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
     InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
     InlineData(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
     InlineData(new[] { 1, 5, 4, 2, 3, 11, 6, 9, 8, 10, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
     InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
     InlineData(new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
    public void CountingSort(int[] array, IEnumerable<int> sorted)
    {
        Sorts.CountingSort
             .Sort(array)
             .Should().Equal(sorted);
    }
}