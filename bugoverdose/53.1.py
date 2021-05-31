"""
    코드챌린지: 리스트에서 서로 인접한 요소의 부호(+-)가 동일하면 하나의 요소로 합치기.
"""
from typing import List

class Solution:
    def combinePlusMinusTogether(_, nums: List[int]) -> List[int]:
        index: int = 1
        list_length: int = len(nums)
        plus_minus: int = 1 if nums[0] >= 0 else -1
        for i in range(list_length-1):
            cur_plus_minus: int = 1 if nums[index] >= 0 else -1
            if plus_minus == cur_plus_minus: 
                nums[index-1] += nums[index] 
                del nums[index] 
            else:
                plus_minus *= -1 
                index += 1
        return nums
 
# Testcase 
s = Solution() 
print(s.combinePlusMinusTogether([-2, 1, -3, 4, -1, 2, 1, -5, 4])) # [-2, 1, -3, 4, -1, 3, -5, 4]
print(s.combinePlusMinusTogether([-2,-1])) # [-3]
print(s.combinePlusMinusTogether([1])) # [1]
print(s.combinePlusMinusTogether([1, 1, 1, -1, -1, -1, 1, 1])) # [3, -3, 2]

# ===============================================================
# 7196 ms
class PrevSolution:
    def maxSubArray(_, nums: List[int]) -> int:
        index: int = 1
        list_length: int = len(nums)
        plus_minus: int = 1 if nums[0] >= 0 else -1
        for i in range(list_length-1):
            cur_plus_minus: int = 1 if nums[index] >= 0 else -1
            if plus_minus == cur_plus_minus: 
                if plus_minus > 0:
                    nums[index-1] += nums[index] 
                    del nums[index] 
            else:
                plus_minus *= -1 
                index += 1
        
        max_sum = sorted(nums)[-1]
        for index in range(len(nums)):
            if nums[index] > 0:
                compare_sum = 0
                for cur in range(index, len(nums)):
                    compare_sum += nums[cur] 
                    if compare_sum > max_sum:
                        max_sum = compare_sum
        return max_sum 
