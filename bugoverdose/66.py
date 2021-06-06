from typing import List

# Runtime: 24 ms, faster than 96.98% of Python3 online submissions for Plus One.
# Memory Usage: 14.3 MB, less than 43.85% of Python3 online submissions for Plus One.
class Solution:
    def plusOne(_, digits: List[int]) -> List[int]:
        return list( map(int, str(int(str(digits)[1:-1].replace(", ", "")) + 1)) )

"""
66. Plus One
Given a non-empty array of decimal digits representing a non-negative integer, increment one to the integer.
The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.
You may assume the integer does not contain any leading zero, except the number 0 itself.

Example 1:
Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.

Example 2:
Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.

Example 3:
Input: digits = [0]
Output: [1]
 
Constraints:
1 <= digits.length <= 100
0 <= digits[i] <= 9
"""

# Testcase 

s = Solution() 
print(s.plusOne([1, 2])) #  ['1', '3']
