from typing import List

# Runtime: 1220 ms, faster than 5.05% of Python3 online submissions for Container With Most Water.
# Memory Usage: 27.5 MB, less than 43.92% of Python3 online submissions for Container With Most Water.
class Solution:
    def maxArea(_, height: List[int]) -> int:
        start = 0 
        end = len(height) - 1 
        max_area = end * min(height[start], height[end])
        while end - start >= 2:
            if height[start] > height[end]:
                end -= 1
            else: 
                start += 1
            max_area = max(max_area, (end - start) * min(height[start], height[end]))
        return max_area

# Time Limit Exceeded
class BruteSolution:
    def maxArea(_, height: List[int]) -> int:
        max_area = 1
        max_height = max(height)
        for i in range(len(height)):
            if max_height >= height[i]:
                for j in range(i+1, len(height)):
                    cur_area = (j-i) * min(height[i], height[j])
                    max_area = max(cur_area, max_area) 
        return max_area

"""
11. Container With Most Water
Given n non-negative integers a1, a2, ..., an , 
where each represents a point at coordinate (i, ai). 
n vertical lines are drawn such that the two endpoints of the line i is at (i, ai) and (i, 0).
Find two lines, which, together with the x-axis forms a container, 
such that the container contains the most water.

Notice that you may not slant the container.

Example 1:
Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

Example 2:
Input: height = [1,1]
Output: 1

Example 3:
Input: height = [4,3,2,1,4]
Output: 16

Example 4:
Input: height = [1,2,1]
Output: 2

Constraints:
n == height.length
2 <= n <= 105
0 <= height[i] <= 104
"""

# Testcase 

s = Solution()
print(s.maxArea([1,8,6,2,5,4,8,3,7])) # 49
print(s.maxArea([1, 1])) # 1
print(s.maxArea([4,3,2,1,4])) # 16
print(s.maxArea([1,2,1])) # 2
print(s.maxArea([1, 7, 3, 10, 5, 3])) # 15
print(s.maxArea([1,2,3,4,5,6,7,8,9,10,9,8,7,6,5,4,3,2,1])) # 50
