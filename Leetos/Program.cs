using Leetos.easy;

namespace Leetos
{
    public static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Leetos");
            Console.WriteLine("Local LeetCode problem runner");
            Console.WriteLine();

            while (true)
            {
                PrintMenu();

                Console.Write("Choose an option: ");
                string? input = Console.ReadLine()?.Trim();

                Console.WriteLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                if (input.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }

                if (input.Equals("l", StringComparison.OrdinalIgnoreCase))
                {
                    PrintProblems();
                    continue;
                }

                if (input.Equals("a", StringComparison.OrdinalIgnoreCase))
                {
                    RunAllProblems();
                    continue;
                }

                if (input.Equals("e", StringComparison.OrdinalIgnoreCase))
                {
                    //RunProblemsByDifficulty(Difficulty.Easy);
                    continue;
                }

                if (int.TryParse(input, out int problemNumber))
                {
                    RunProblemByNumber(problemNumber);
                    continue;
                }

                Console.WriteLine("Unknown option.");
                Console.WriteLine();
            }
        }
    }
}