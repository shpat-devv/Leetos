class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        prefix = ""
        current_char = ""

        index = 0
        while index < len(strs[0]):
            for current_word in range(len(strs)):
                if len(strs[current_word]) <= index:
                    return prefix
                
                if current_word == 0:
                    if strs[current_word][index] == "":
                        return prefix
                    current_char = strs[current_word][index]
            
                elif strs[current_word][index] != current_char:
                    return prefix

            prefix += current_char
            index += 1

        return prefix

test = Solution()

print(test.longestCommonPrefix(["flower","flow","flight"]))
print(test.longestCommonPrefix(["", ""]))
print(test.longestCommonPrefix(["ab", "ab", "a"]))