namespace Leetos;

public class Helper
{
    private static readonly string[] Menu = new[] { "q: Quit", "l: List Problems", "a: Run All Problems", "i: Run Specific Problem" };
    
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
        Problems.Probs.ForEach(p => Console.WriteLine(
            p.Number + ". " + p.Title + " :" + p.Difficulty + "\n"));
    }
        
    public static void RunAllProblems()
    {
        foreach (var prob in Problems.Probs)
        {
            Console.WriteLine($"Problem: {prob.Title} \n");
            foreach (var c in prob.Cases)
            {
                Console.WriteLine($"Case: {c.Name}");
                Console.WriteLine($"Output: \n{c.Run}");
                Console.WriteLine($"Expected Output: \n{c.Expected}\n");
            }
        }
    }
    
    public static void RunSpecificProblem(int x)
    {
            
    }
}