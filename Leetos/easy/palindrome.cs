namespace Leetos.easy
{
    public static class Palindrome
    {
        public static bool Run(int x)
        {
            String x_str = x.ToString();
            String y_str = "";

            for (int i = x_str.Length - 1; i >= 0; i--)
            {
                y_str += x_str[i];
            }

            if (x_str == y_str)
            {
                return true;
            }

            return false;
        }
    }
}