using DataStructureAndAlgo.Misc;
using DataStructureAndAlgo.Searches;
using DataStructureAndAlgo.Sorts;
using Spectre.Console;

AnsiConsole.Write(
    new FigletText("Algorithms")
        .LeftJustified()
        .Color(Color.Red));

//----------------------------------------------------------------------------------------------------------------------
//---- DEPTH FIRST SEARCH (DFS)
//----------------------------------------------------------------------------------------------------------------------
Rule("[red]DFS Algorithms[/]");
var tree = new List<int>[]
{
    [1, 2], // 0
    [0, 3], // 1
    [0, 3], // 2
    [4, 2], // 3
    [3]     // 4
};
AnsiConsole.MarkupLine("[red]Recursive. [/]");
Execute(t => DfsRecursive.Explore(t, i => AnsiConsole.Write($"{i} ")), tree);

AnsiConsole.MarkupLine("[red]Stack. [/]");
Execute(t => DfsStack.Explore(t, i => AnsiConsole.Write($"{i} ")), tree);


//----------------------------------------------------------------------------------------------------------------------
// ---- SEARCH ALGORITHMS
//----------------------------------------------------------------------------------------------------------------------
Rule("[red]Search Algorithms[/]");
AnsiConsole.MarkupLine("[red]Binary search. [/]");
var orderedVector = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (var find in orderedVector)
{
    var index = Binary.Search(orderedVector, find);
    AnsiConsole.MarkupLine($"\tFound: [yellow]{find}[/] at index {index?.ToString() ?? "[RED]NULL[/]"}");
}

var idx = Binary.Search(orderedVector, 14);
AnsiConsole.MarkupLine($"\tFound: [yellow]{14}[/] at index {idx?.ToString() ?? "[RED]NULL[/]"}");
// No result
//----------------------------------------------------------------------------------------------------------------------
// ---- SORT ALGORITHMS
//----------------------------------------------------------------------------------------------------------------------

Rule("[red]Sort Algorithms[/]");
AnsiConsole.MarkupLine("[red]Bubble sort. [/]");

var vector = new[] { 10, 5, 4, 6, 1, 9, 3, 2, 7, 8 };
AnsiConsole.MarkupLine($"\tRandom vector  : {string.Join(", ", vector)}");
AnsiConsole.MarkupLine($"\tOrdered vector : {string.Join(", ", orderedVector)}");
var reverseVector = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
AnsiConsole.MarkupLine($"\tReversed vector: {string.Join(", ", reverseVector)}");

Bubble.Sort(vector);
Bubble.Sort(orderedVector);
Bubble.Sort(reverseVector);

AnsiConsole.MarkupLine($"\tSorted vector (random)  : {string.Join(", ", vector)}");
AnsiConsole.MarkupLine($"\tSorted vector (ordered) : {string.Join(", ", orderedVector)}");
AnsiConsole.MarkupLine($"\tSorted vector (reversed): {string.Join(", ", reverseVector)}");
//----------------------------------------------------------------------------------------------------------------------
// ---- MISCELLANEOUS
//----------------------------------------------------------------------------------------------------------------------

Rule("[red]Miscellaneous[/]");
AnsiConsole.MarkupLine("[red]Fibonacci (stack). [/]");
var sequence1 = Fibonacci.SequenceStack(6);

AnsiConsole.MarkupLine($"\tSequence: {string.Join(", ", sequence1)}");

AnsiConsole.MarkupLine("[red]Fibonacci (recursive). [/]");
var sequence2 = Fibonacci.SequenceRecursive(6);

AnsiConsole.MarkupLine($"\tSequence: {string.Join(", ", sequence2)}");

//----------------------------------------------------------------------------------------------------------------------
// ---- METHODS & HELPERS
//----------------------------------------------------------------------------------------------------------------------
return;

void Execute(Action<IReadOnlyList<List<int>>> algorithm, IReadOnlyList<List<int>> tree)
{
    AnsiConsole.MarkupLine($"\tGraph size: {tree.Count} ");
    AnsiConsole.Markup("\tVisited: ");

    algorithm(tree);

    AnsiConsole.WriteLine();
}

void Rule(string markup)
{
    var renderer = new Rule(markup)
    {
        Justification = Justify.Left
    };
    AnsiConsole.Write(renderer);
}