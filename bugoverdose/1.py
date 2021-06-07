from typing import List

# 56 ms
class Solution:
    def twoSum(_, nums: List[int], target: int) -> List[int]:
        dict = { nums[0]: 0 }
        i = 1
        while i >= 1:             
            if dict.keys().__contains__(target - nums[i]): 
                return [nums.index(target - nums[i]), i]
            else:
                dict[nums[i]] = i
                i += 1
                
# 60 ms
class PrevSolution3:
    def twoSum(_, nums: List[int], target: int) -> List[int]:
        dict = {}
        for i in range(len(nums)):             
            if dict.keys().__contains__(target - nums[i]): 
                return [nums.index(target - nums[i]), i]
            else:
                dict[nums[i]] = i

# 1020 ms
class PrevSolution2:
    def twoSum(_, nums: List[int], target: int) -> List[int]:
        dict = {}
        for i in range(len(nums)):             
            if list(dict.values()).__contains__(target - nums[i]): 
                return [nums.index(target - nums[i]), i]
            else:
                dict[i] = nums[i]

# 4872 ms
class PrevSolution1:
    def twoSum(_, nums: List[int], target: int) -> List[int]:
        for i in range(len(nums)):
            for j in range(len(nums)):
                if i == j:
                    break
                elif nums[i] + nums[j] == target:
                    return [j, i]
"""
1. Two Sum
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]
 
Constraints:
2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 
Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
"""

# Testcase 

s = Solution()
print(s.twoSum([2, 7, 11, 15] , 9)) # [0, 1]
print(s.twoSum([3, 2, 4], 6)) # [1, 2]
print(s.twoSum([3, 3], 6)) # [0, 1]
