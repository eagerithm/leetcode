from typing import List

class Solution:
    def longestCommonPrefix(_, strs: List[str]) -> str:
        if len(strs) == 1:
            return strs[0] 
        common_prefix = ""
        try:
            for i in range(len(strs[0])): 
                for j in range(1, len(strs)):   
                    if strs[0][i] != strs[j][i]:
                        return common_prefix
                    if j == len(strs) - 1:
                        common_prefix += strs[0][i]  
        finally:
            return common_prefix


"""
14. Longest Common Prefix
Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".

Example 1:
Input: strs = ["flower", "flow", "flight"]
Output: "fl"

Example 2:
Input: strs = ["dog", "racecar", "car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 
Constraints:
1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lower-case English letters.
"""

# Testcase 

s = Solution()
print(s.longestCommonPrefix(["flower", "flow", "flight"]))  
print(s.longestCommonPrefix(["flower"])) 
print(s.longestCommonPrefix(["dog", "racecar", "car"])) 
print(s.longestCommonPrefix(["ab", "a"])) 