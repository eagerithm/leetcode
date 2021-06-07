from typing import List

# Runtime: 48 ms, faster than 69.84% of Python3 online submissions for Search Insert Position.
# Memory Usage: 14.9 MB, less than 92.97% of Python3 online submissions for Search Insert Position.
class Solution:
    def searchInsert(_, nums: List[int], target: int) -> int:
        try:
            return nums.index(target)
        except:
            nums += [target]
            nums.sort()
            return nums.index(target)

"""
35. Search Insert Position
Given a sorted array of distinct integers and a target value, 
return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.
You must write an algorithm with O(log n) runtime complexity.

Example 1:
Input: nums = [1,3,5,6], target = 5
Output: 2

Example 2:
Input: nums = [1,3,5,6], target = 2
Output: 1

Example 3:
Input: nums = [1,3,5,6], target = 7
Output: 4

Example 4:
Input: nums = [1,3,5,6], target = 0
Output: 0

Example 5:
Input: nums = [1], target = 0
Output: 0
 
Constraints:
1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums contains distinct values sorted in ascending order.
-104 <= target <= 104
"""

# Testcase 

s = Solution() 
print(s.searchInsert([1,3,5,6], 5)) # 2
print(s.searchInsert([1,3,5,6], 2)) # 1
print(s.searchInsert([1,3,5,6], 7)) # 4
print(s.searchInsert([1,3,5,6], 0)) # 0
print(s.searchInsert([1], 0))       # 0
