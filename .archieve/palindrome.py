class Solution:
    def isPalindrome(self, x: int) -> bool:
        x_str = str(x)
        y_str = ""

        for char in range(len(x_str) - 1, -1 , -1):
            y_str += x_str[char]

        if x_str == y_str:
            return True
        return False

test = Solution()

if test.isPalindrome(121):
    print("pass")      