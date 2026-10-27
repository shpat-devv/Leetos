namespace Leetos
{
    public static class Problems
    {
        public static readonly List<Problem> Probs =
        [
            new Problem
            {
                Number = 2089,
                Title = "Find Target Indices After Sorting Array",
                Difficulty = Difficulty.Easy,
                Cases =
                [
                    new ProblemCase(
                        name: "target exists twice",
                        run: () =>  easy.P2089.Run([1, 2, 5, 2, 3], 2),
                        expected: new List<int> { 1, 2 }
                    ),
                    new ProblemCase(
                        name: "target exists once",
                        run: () => easy.P2089.Run([1, 2, 5, 2, 3], 3),
                        expected: new List<int> { 3 }
                    ),
                    new ProblemCase(
                        name: "target exists once at end",
                        run: () => easy.P2089.Run([1, 2, 5, 2, 3], 5),
                        expected: new List<int> { 4 }
                    )
                ]
            }
        ];
    }

    public class Problem
    {
        public int Number { get; init; }
        public string Title { get; init; } = string.Empty;
        public Difficulty Difficulty { get; init; }
        public IReadOnlyList<ProblemCase> Cases { get; init; } = [];
    }

    public class ProblemCase
    {
        public ProblemCase(
            string name,
            Func<object?> run,
            object? expected)
        {
            Name = name;
            Run = run;
            Expected = expected;
        }

        public string Name { get; }
        public Func<object?> Run { get; }
        public object? Expected { get; }
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }
}