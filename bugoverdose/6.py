# Runtime: 56 ms, faster than 77.53% of Python3 online submissions for ZigZag Conversion.
# Memory Usage: 14.6 MB, less than 24.18% of Python3 online submissions for ZigZag Conversion.
class Solution:
    def convert(_, s: str, numRows: int) -> str:
        if numRows == 1:
            return s
        rows = []
        for i in range(numRows):
            rows.append("")
        cur_row = 0
        direction = 1
        for i in range(len(s)): 
            rows[cur_row] += s[i]
            if cur_row == numRows - 1:
                direction = -1
            if cur_row == 0:
                direction = 1
            cur_row += direction 
        return str(rows)[2:-2].replace("', '", "")

"""
6. ZigZag Conversion
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"
Write the code that will take a string and make this conversion given a number of rows:
string convert(string s, int numRows);

Example 1:
Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"

Example 2:
Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:
P     I    N
A   L S  I G
Y A   H R
P     I

Example 3:
Input: s = "A", numRows = 1
Output: "A"
 
Constraints:
1 <= s.length <= 1000
s consists of English letters (lower-case and upper-case), ',' and '.'.
1 <= numRows <= 1000
"""

# Testcase 

s = Solution() 
print(s.convert("PAYPALISHIRING", 3)) # PAHNAPLSIIGYIR
print(s.convert("PAYPALISHIRING", 4)) # PINALSIGYAHRPI
print(s.convert("A", 1)) # A
 