namespace Leetos
{
    public static class Problems
    {
        public static List<Problem> Probs =
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
                        run: string.Join(", ", easy.P2089.Run([1, 2, 5, 2, 3], 2)),
                        expected: "1, 2"
                    ),
                    new ProblemCase(
                        name: "target exists once",
                        run: string.Join(", ", easy.P2089.Run([1, 2, 5, 2, 3], 3)),
                        expected: "3"
                    ),
                    new ProblemCase(
                        name: "target exists once at end",
                        run: string.Join(", ", easy.P2089.Run([1, 2, 5, 2, 3], 5)),
                        expected: "4"
                    )
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
                        name: "needle exists",
                        run: easy.P28.Run("sadbutsad", "sad"),
                        expected: "0"
                    ),
                    new ProblemCase(
                        name: "needle does not exist",
                        run: easy.P28.Run("leetcode", "leeto"),
                        expected: "-1"
                    )
                ]
            },

            new Problem
            {
                Number = 20,
                Title = "Valid Parentheses",
                Difficulty = Difficulty.Easy,
                Cases =
                [
                    new ProblemCase(
                        name: "single pair",
                        run: easy.P20.Run("()"),
                        expected: "true"
                    ),
                    new ProblemCase(
                        name: "multiple valid pairs",
                        run: easy.P20.Run("()[]{}"),
                        expected: "true"
                    ),
                    new ProblemCase(
                        name: "invalid pair",
                        run: easy.P20.Run("(]"),
                        expected: "false"
                    )
                ]
            },

            new Problem
            {
                Number = 13,
                Title = "Roman to Integer",
                Difficulty = Difficulty.Easy,
                Cases =
                [
                    new ProblemCase(
                        name: "III",
                        run: easy.P13.Run("III"),
                        expected: "3"
                    ),
                    new ProblemCase(
                        name: "LVIII",
                        run: easy.P13.Run("LVIII"),
                        expected: "58"
                    ),
                    new ProblemCase(
                        name: "MCMXCIV",
                        run: easy.P13.Run("MCMXCIV"),
                        expected: "1994"
                    )
                ]
            },

            new Problem
            {
                Number = 9,
                Title = "Palindrome Number",
                Difficulty = Difficulty.Easy,
                Cases =
                [
                    new ProblemCase(
                        name: "positive palindrome",
                        run: easy.P9.Run(121),
                        expected: "true"
                    ),
                    new ProblemCase(
                        name: "negative number",
                        run: easy.P9.Run(-121),
                        expected: "false"
                    ),
                    new ProblemCase(
                        name: "not palindrome",
                        run: easy.P9.Run(10),
                        expected: "false"
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
            object? run,
            string expected)
        {
            Name = name;
            Run = run;
            Expected = expected;
        }

        public string Name { get; }
        public object? Run { get; }
        public string Expected { get; }
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }
}