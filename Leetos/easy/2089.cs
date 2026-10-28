namespace Leetos.easy
{
    internal static class P2089
    {
        public static IList<int> Run(int[] nums, int target) {
            List<int> res = [];

            int n = nums.Length;

            for (int i = 1; i < n; i++)
            {
                int key = nums[i];
                int j = i - 1;

                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    nums[j] = key;
                    j -= 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] == target)
                {
                    res.Add(i);
                }
            }

            return res;
        }
    }
}