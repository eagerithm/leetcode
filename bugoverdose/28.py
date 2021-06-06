# Runtime: 32 ms, faster than 67.22% of Python3 online submissions for Implement strStr().
# Memory Usage: 14.2 MB, less than 92.16% of Python3 online submissions for Implement strStr().
class Solution:
    def strStr(_, haystack: str, needle: str) -> int:
        if len(needle) == 0:
            return 0
        if len(haystack) >= len(needle):
            for i in range(len(haystack) - len(needle) + 1):  
                if haystack[i] == needle[0]: 
                    for j in range(len(needle)): 
                        if haystack[i + j] != needle[j]:
                            break
                        if j == len(needle) - 1:
                            return i 
        return -1

# Runtime: 28 ms, faster than 86.09% of Python3 online submissions for Implement strStr().
# Memory Usage: 14.3 MB, less than 77.58% of Python3 online submissions for Implement strStr().
class PrevSolution:
    def strStr(_, haystack: str, needle: str) -> int:
        try:
            return haystack.index(needle)
        except:
            if len(needle) == 0:
                return 0
            else:
                return -1

"""
28. Implement strStr()
Implement strStr().
Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Clarification:
What should we return when needle is an empty string? This is a great question to ask during an interview.
For the purpose of this problem, we will return 0 when needle is an empty string. 
This is consistent to C's strstr() and Java's indexOf().

Example 1:
Input: haystack = "hello", needle = "ll"
Output: 2

Example 2:
Input: haystack = "aaaaa", needle = "bba"
Output: -1

Example 3:
Input: haystack = "", needle = ""
Output: 0
 
Constraints:
0 <= haystack.length, needle.length <= 5 * 104
haystack and needle consist of only lower-case English characters.
"""

# Testcase 

s = Solution() 
print(s.strStr("hello", "ll")) # 2
print(s.strStr("aaaaa", "bba")) # -1
print(s.strStr("", "a")) # -1
print(s.strStr("", "")) # 0
print(s.strStr("a", "a")) # 0
print(s.strStr("mississippi", "issip")) # 4
print(s.strStr("mississippi", "issipi")) # -1
print(s.strStr("abcd", "cde")) # -1
print(s.strStr("mississippi", "sipp")) # 6
