namespace Leetos.easy
{
    public static class P20
    {
        public static bool Run(string s)
        {
            var pars = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            List<char> stack = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (pars.ContainsKey(s[i]))
                {
                    stack.Add(s[i]);
                }

                else if (stack.Count != 0 && pars[stack[stack.Count - 1]] == s[i])
                {
                    stack.RemoveAt(stack.Count - 1);
                }

                else
                {
                    return false;
                }

            }

            if (stack.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
