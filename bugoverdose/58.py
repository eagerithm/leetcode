# Runtime: 32 ms, faster than 48.88% of Python3 online submissions for Length of Last Word.
# Memory Usage: 14.1 MB, less than 86.47% of Python3 online submissions for Length of Last Word.
class Solution:
    def lengthOfLastWord(_, s: str) -> int:
        s = s.strip() 
        if s.find(" ") != -1:
            return s[::-1].find(" ")
        return len(s)

# 36 ms
class PrevSolution2:
    def lengthOfLastWord(_, s: str) -> int:
        s = s.strip() # 원본은 그대로. 좌우 whitespace 제거하여 반환.
        if " " in s:
            return s[::-1].index(" ")
        return len(s)

# 44 ms
class PrevSolution1:
    def lengthOfLastWord(_, s: str) -> int:
        if " " in s:
            while s[-1] == " ":  # string.strip() : remove whitespace 부분적으로 직접 구현
                s = s[:-1]
                if len(s) == 0:
                    return 0 
            if " " in s:
                return s[::-1].index(" ")
        return len(s)


"""
58. Length of Last Word
Given a string s consists of some words separated by spaces, return the length of the last word in the string. If the last word does not exist, return 0.
A word is a maximal substring consisting of non-space characters only.

Example 1:
Input: s = "Hello World"
Output: 5

Example 2:
Input: s = " "
Output: 0
 
Constraints:
1 <= s.length <= 104
s consists of only English letters and spaces ' '.
"""

# Testcase 

s = Solution() 
print(s.lengthOfLastWord("Hello World")) # 5 
print(s.lengthOfLastWord(" ")) # 0
print(s.lengthOfLastWord("a")) # 1
print(s.lengthOfLastWord("a ")) # 1