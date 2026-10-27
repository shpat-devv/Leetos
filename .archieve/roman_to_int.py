class Solution:
    r_nums = {
        "I" : 1,
        "V" : 5,
        "X" : 10,
        "L" : 50,
        "C" : 100,
        "D" : 500,
        "M" : 1000
    }

    def romanToInt(self, s: str) -> int:
        res = 0
        y = 4000

        for x in s:
            z = self.r_nums[x]

            if z > y:
                z -= y * 2
            res += z

            y = z

        print(res)


test = Solution()

test.romanToInt("III")
test.romanToInt("LVIII")
test.romanToInt("MCMXCIV")