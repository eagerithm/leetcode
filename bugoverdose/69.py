# 492 ms, 14.2 MB
class Solution:
    def mySqrt(_, x: int) -> int:
        i: int = round(x / 2)
        while i * i > x:
            i = round(i / 2)
        if i > 0:
            while round(i * 1.5) * round(i * 1.5) < x:
                i = round(i * 1.5) 
        while i * i <= x:
            i += 1
        return i - 1

# 984 ms, 14.1 MB
class SlowSolution3:
    def mySqrt(_, x: int) -> int:
        i: int = round(x / 2)
        while i * i > x:
            i = round(i / 2)
        while i * i <= x:
            i += 1
        return i - 1        

# 1780 ms, 14.3 MB
class SlowSolution2:
    def mySqrt(_, x: int) -> int:
        i: int = 1
        digit = round((len(str(x)) - 1) / 2)
        for __ in range(digit - 1):
            i *= 10
        while i * i <= x:
            i += 1
        return i - 1

# 2652 ms, 13.8 MB
class SlowSolution1:
    def mySqrt(_, x: int) -> int:
        i: int = 0
        while i * i <= x:
            i += 1
        return i - 1

"""
69. Sqrt(x)
Given a non-negative integer x, compute and return the square root of x.
Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.

Note: You are not allowed to use any built-in exponent function or operator, 
such as pow(x, 0.5) or x ** 0.5.

Example 1:
Input: x = 4
Output: 2

Example 2:
Input: x = 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.

Constraints:
0 <= x <= 2^31 - 1

정수 x에 대해 [a^2 <= x < (a + 1)^2]를 만족하는 정수 a값을 찾는 알고리즘
- [a^2 <= x < (a + 1)^2] ==> [x^(1/2) - 1 < a <= x^(1/2)] 
- 나중에 다시 제대로 풀기   
"""

# Testcase 

s = Solution() 
print(s.mySqrt(0)) # 0
print(s.mySqrt(1)) # 1
print(s.mySqrt(3)) # 1
print(s.mySqrt(4)) # 2
print(s.mySqrt(8)) # 2
print(s.mySqrt(9)) # 3
print(s.mySqrt(90000)) # 300
print(s.mySqrt(10000000)) # 3162
