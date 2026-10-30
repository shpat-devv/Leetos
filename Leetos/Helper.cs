using System.Collections;

namespace Leetos;

public class Helper
{
    public static string Stringify(object? value)
    {
        if (value is null) return "null";

        if (value is IEnumerable e and not string)
        {
            return "[" + string.Join(", ", e.Cast<object?>().Select(Stringify)) + "]";
        }

        return value.ToString() ?? "";
    }
}