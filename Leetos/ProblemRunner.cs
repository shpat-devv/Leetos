namespace Leetos;

public static class ProblemRunner
{
    private static readonly string[] Menu =
    [
        "q: Quit", 
        "l: List Problems", 
        "a: Run All Problems", 
        "i: Run Specific Problem"
    ];
    
    public static void PrintMenu()
    {
        foreach (var item in Menu)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("\n");
    }
        
    public static void PrintProblems()
    {
        ProblemRegistry.Problems.ForEach(p => Console.WriteLine(
            p.Number + ". " + p.Title + " :" + p.Difficulty + "\n"));
    }
        
    public static void RunAllProblems()
    {
        foreach (var prob in ProblemRegistry.Problems)
        {
            Console.WriteLine($"Problem: {prob.Title}\n");
            foreach (var c in prob.Cases)
            {
                var result = c.Execute();

                if (result.Error is not null)
                    Console.WriteLine($"Threw: {result.Error.Message}");
                else
                    Console.WriteLine(result.Passed ? "Test passed" : "Test FAILED");

                Console.WriteLine($"Output:   {Helper.Stringify(result.Output)}");
                Console.WriteLine($"Expected: {Helper.Stringify(c.Expected)}");
                Console.WriteLine($"Time:     {result.Elapsed.TotalMilliseconds:F2} ms\n");
            }
        }
    }
    
    public static void RunSpecificProblem(int x)
    {
            
    }
}