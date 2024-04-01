using System.Text;
using DataStructureAndAlgo.Searches;
using DataStructureAndAlgo.Sorts;
using FluentAssertions;
using Xunit;

namespace DataStructureAndAlgo.Tests;

public class AlgorithmTests
{

    [Theory,
     InlineData(1, 0),
     InlineData(2, 1),
     InlineData(3, 2),
     InlineData(4, 3),
     InlineData(5, 4),
     InlineData(6, 5),
     InlineData(10, 6),
     InlineData(11, 6),
     InlineData(100, 66),
     InlineData(110, 66),
     InlineData(111, 66),
     InlineData(112, 66),
     InlineData(1000, 666)]
    public void BinarySearch_Find(int size, int toFind)
    {
        var array = Helpers.BuildArray(size);
        Binary.Search(array, toFind)
              .Should().NotBeNull()
              .And.Be(toFind);
    }
    
    [Theory,
     InlineData(1, 10),
     InlineData(2, 11),
     InlineData(3, 12),
     InlineData(4, 13),
     InlineData(5, 14),
     InlineData(6, 15),
     InlineData(110, 166),
     InlineData(111, 166),
     InlineData(112, 166),
     InlineData(1000, 1666)]
    public void BinarySearch_DoNotFind(int size, int toFind)
    {
        var array = Helpers.BuildArray(size);
        Binary.Search(array, toFind)
              .Should().BeNull();
    }

    [Theory,
     InlineData("""
                1,2
                3
                3
                4

                """, "01342")]
    public void DfsWithRecursive(string graph, string visitPath)
    {
        var tree = Helpers.TreeFromString(graph);
        var path = new StringBuilder();

        DfsRecursive.Explore(tree, i => path.Append(i));

        path.ToString()
            .Should().Be(visitPath);
    }

    [Theory,
     InlineData("""
                1,2
                3
                3
                4

                """, "02341")]
    public void DfsWithStack(string graph, string visitPath)
    {
        var tree = Helpers.TreeFromString(graph);
        var path = new StringBuilder();

        DfsStack.Explore(tree, i => path.Append(i));

        path.ToString()
            .Should().Be(visitPath);
    }

    [Theory,
     InlineData("""
                1,2
                3
                3
                4

                """, "01234")]
    public void BfsWithQueue(string graph, string visitPath)
    {
        var tree = Helpers.TreeFromString(graph);
        var path = new StringBuilder();

        BfsQueue.Explore(tree, i => path.Append(i));

        path.ToString()
            .Should().Be(visitPath);
    }
}