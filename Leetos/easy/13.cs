namespace Leetos.easy
{
    public static class P13
    {
        static readonly Dictionary<char, int> r_nums = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int Run(string s)
        {
            int res = 0;
            int y = 4000;

            foreach (char x in s)
            {
                int z = r_nums[x];

                if (z > y)
                {
                    z -= y * 2;
                }

                res += z;
                y = z;
            }

            return res;
        }
    }
}