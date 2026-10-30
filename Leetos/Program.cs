namespace Leetos
{
    public static class Program
    {
        private static void Main()
        {
            while (true)
            {
                ProblemRunner.PrintMenu();

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
                    ProblemRunner.PrintProblems();
                    continue;
                }
                
                if (input.Equals("a", StringComparison.OrdinalIgnoreCase))
                {
                    ProblemRunner.RunAllProblems();
                    continue;
                }

                Console.WriteLine("Unknown option.");
                Console.WriteLine();
            }
        }
    }
}