# Runtime: 56 ms, faster than 5.66% of Python3 online submissions for Add Binary.
# Memory Usage: 14 MB, less than 92.75% of Python3 online submissions for Add Binary.
class Solution:
    def addBinary(_, a: str, b: str) -> str:
        if len(a) < len(b):
            [a, b] = [b, a]
        a = list(map(int, a[::-1]))
        b = b[::-1]
        for i in range(len(b)):
            a[i] += int(b[i])
        for i in range(len(a)):
            if a[i] >= 2:
                a[i] -= 2
                if i == len(a) - 1:
                    a.append(1)
                else:
                    a[i+1] += 1
        return str(a)[1:-1].replace(", ","")[::-1]

# 60 ms, 14.1 MB
class PrevSolution:
    def addBinary(_, a: str, b: str) -> str:
        return str(bin(int(a, 2) + int(b, 2)))[2:]

"""
67. Add Binary
Given two binary strings a and b, return their sum as a binary string.

Example 1:
Input: a = "11", b = "1"
Output: "100"

Example 2:
Input: a = "1010", b = "1011"
Output: "10101"

Constraints:
1 <= a.length, b.length <= 104
a and b consist only of '0' or '1' characters.
Each string does not contain leading zeros except for the zero itself.
"""

# Testcase 

s = Solution() 
print(s.addBinary("1","11")) # "100"
print(s.addBinary("1011", "1010")) # "10101"
print(s.addBinary("1111", "1111")) # "11110"
