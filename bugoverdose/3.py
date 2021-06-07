# Runtime: 64 ms, faster than 62.74% of Python3 online submissions for Longest Substring Without Repeating Characters.
# Memory Usage: 14.3 MB, less than 78.46% of Python3 online submissions for Longest Substring Without Repeating Characters.
class Solution:
    def lengthOfLongestSubstring(_, s: str) -> int:
        max_length = 0 
        list = []
        for i in range(len(s)): 
            if s[i] in list: 
                list = list[list.index(s[i])+1:] 
            list.append(s[i])
            if max_length < len(list):
                max_length = len(list)
        return max_length

"""
3. Longest Substring Without Repeating Characters
Given a string s, find the length of the longest substring without repeating characters.

Example 1:
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.

Example 2:
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.

Example 3:
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

Example 4:
Input: s = ""
Output: 0
 
Constraints:
0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
"""

# Testcase 

s = Solution() 
print(s.lengthOfLongestSubstring("aab")) # 2
print(s.lengthOfLongestSubstring("dvdf")) # 3
print(s.lengthOfLongestSubstring("abcabcbb")) # 3
print(s.lengthOfLongestSubstring("bbbbb")) # 1
print(s.lengthOfLongestSubstring("pwwkew")) # 3
