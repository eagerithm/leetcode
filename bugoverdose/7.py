class Solution:
    def reverse(_, x: int) -> int:
        plus_minus: int = 1 if x >= 0 else -1    
        reversed: int = plus_minus * int(str(abs(x))[::-1])
        if reversed < -2**31 or reversed > 2**31 - 1:
            return 0
        else:
            return reversed

"""
7. Reverse Integer
Given a signed 32-bit integer x, return x with its digits reversed. 
If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.
Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

Example 1:
Input: x = 123
Output: 321

Example 2:
Input: x = -123
Output: -321

Example 3:
Input: x = 120
Output: 21

Example 4:
Input: x = 0
Output: 0
 
Constraints:
-2^31 <= x <= 2^31 - 1
"""

# Testcase 

s = Solution() 
print(s.reverse(2147483647)) # 0
print(s.reverse(123)) # 321 
print(s.reverse(-123)) # -321
print(s.reverse(120)) # 21
print(s.reverse(0)) # 0

