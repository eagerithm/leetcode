from typing import List

# Runtime: 64 ms, faster than 72.70% of Python3 online submissions for Maximum Subarray.
# Memory Usage: 15 MB, less than 31.66% of Python3 online submissions for Maximum Subarray.
class Solution:
    def maxSubArray(_, nums: List[int]) -> int:    
        cur_sum = nums[0]
        max_sum = cur_sum
        for cur in nums[1:]: 
            if cur_sum + cur > cur:
                cur_sum += cur
            else:
                cur_sum = cur 
            max_sum = cur_sum if cur_sum > max_sum else max_sum 
        return max_sum 

# 6388 ms 
class PrevSolution:
    def maxSubArray(_, nums: List[int]) -> int:
        max_sum = sorted(nums)[-1]
        for index in range(len(nums)):
            if nums[index] > 0:
                compare_sum = 0
                for cur in range(index, len(nums)):
                    compare_sum += nums[cur] 
                    if compare_sum > max_sum:
                        max_sum = compare_sum
        return max_sum

"""
53. Maximum Subarray
Given an integer array nums, find the contiguous subarray (containing at least one number) 
which has the largest sum and return its sum.

Example 1:
Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.

Example 2:
Input: nums = [1]
Output: 1

Example 3:
Input: nums = [5,4,-1,7,8]
Output: 23

Constraints:
1 <= nums.length <= 3 * 104
-105 <= nums[i] <= 105
 
Follow up: If you have figured out the O(n) solution, 
try coding another solution using the divide and conquer approach, which is more subtle.
"""

# Testcase 

s = Solution() 
print(s.maxSubArray([-2,1,-3,4,-1,2,1,-5,4])) # 6
print(s.maxSubArray([-2,-1])) # -1
print(s.maxSubArray([1])) # 1
print(s.maxSubArray([10000, -50, 10000])) # 19950
print(s.maxSubArray([10, -50, 10])) # 10