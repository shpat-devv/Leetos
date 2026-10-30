using System.Collections;
using System.Diagnostics;

namespace Leetos
{
    public static class ProblemRegistry
    {
        //null values will not pass tests
        public static readonly List<Problem> Problems =
        [
            new Problem
            {
                Number = 2089,
                Title = "Find Target Indices After Sorting Array",
                Difficulty = Difficulty.Easy,
                Cases =
                [
                    new ProblemCase(
                        expected: new List<int> { 1, 2 },
                        run: () => easy.P2089.Run([1, 2, 5, 2, 3], 2)

                    ),
                    new ProblemCase(
                        expected: new List<int> { 3 },
                        run: () => easy.P2089.Run([1, 2, 5, 2, 3], 3)
                    ),
                ]
            },
            
            new Problem
            {
                Number = 28,
                Title = "Find the Index of the First Occurrence in a String",
                Difficulty = Difficulty.Easy,
                Cases =
                [
                    new ProblemCase(
                        expected: 0,
                        run: () => easy.P28.Run("sadbutsad", "sad")
                    ),
                    new ProblemCase(
                        expected: -1,
                        run: () => easy.P28.Run("leetcode", "leeto")
                    )
                ]
            },
            
        ];
    }

    public class Problem
    {
        public int Number { get; init; }
        public string Title { get; init; } = string.Empty;
        public Difficulty Difficulty { get; init; }
        public IReadOnlyList<ProblemCase> Cases { get; init; } = [];
    }

    public record CaseResult(object? Output, bool Passed, TimeSpan Elapsed, Exception? Error = null);

    public class ProblemCase
    {
        private readonly Func<object?> _run;

        //TODO: Convert to primary constructor
        public ProblemCase(object expected, Func<object?> run)
        {
            Expected = expected;
            _run = run; // run is stored as a function
        }

        public object Expected { get; }

        public CaseResult Execute()
        {
            var sw = Stopwatch.StartNew();
            try
            {
                var output = _run();
                sw.Stop();
                return new CaseResult(output, DeepEquals(Expected, output), sw.Elapsed);
            }
            catch (Exception ex)
            {
                sw.Stop();
                return new CaseResult(null, false, sw.Elapsed, ex);
            }
        }

        private static bool DeepEquals(object? a, object? b)
        {
            if (a is null || b is null) return false;
            if (ReferenceEquals(a, b)) return true;
            if (a is string || b is string) return Equals(a, b);

            if (a is IEnumerable ea && b is IEnumerable eb)
            {
                var ia = ea.GetEnumerator();
                var ib = eb.GetEnumerator();
                while (true)
                {
                    bool hasA = ia.MoveNext();
                    bool hasB = ib.MoveNext();
                    if (hasA != hasB) return false;
                    if (!hasA) return true;
                    if (!DeepEquals(ia.Current, ib.Current)) return false;
                }
            }

            return Equals(a, b);
        }
    }

    public enum Difficulty
    {
        Easy = ConsoleColor.Green,
        Medium = ConsoleColor.Yellow,
        Hard = ConsoleColor.Red
    }
}