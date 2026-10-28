namespace Leetos
{
    public static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Helper.PrintMenu();

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
                    Helper.PrintProblems();
                    continue;
                }
                
                if (input.Equals("a", StringComparison.OrdinalIgnoreCase))
                {
                    Helper.RunAllProblems();
                    continue;
                }

                if (input.Equals("i", StringComparison.OrdinalIgnoreCase))
                {
                    Helper.RunSpecificProblem(1);
                    continue;
                }

                Console.WriteLine("Unknown option.");
                Console.WriteLine();
            }
        }
    }
}