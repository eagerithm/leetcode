# #1480 Running Sum of 1d Array

Category: Algorithms
CreatedDate: May 18, 2021 5:08 PM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/running-sum-of-1d-array/

### Question

Given an array `nums`. We define a running sum of an array as `runningSum[i] = sum(nums[0]…nums[i])`.

Return the running sum of `nums`.

**Example 1:**

```
Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
```

**Example 2:**

```
Input: nums = [1,1,1,1,1]
Output: [1,2,3,4,5]
Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
```

**Example 3:**

```
Input: nums = [3,1,2,10,1]
Output: [3,4,6,16,17]

```

**Constraints:**

- `1 <= nums.length <= 1000`
- `10^6 <= nums[i] <= 10^6`

### Answer

```csharp
public class Solution {
    public int[] RunningSum(int[] nums) {
        int sum = nums[0];
        for (int i=1; i<nums.Length; i++) {
            sum += nums[i];
            nums[i] = sum;
        }
        return nums;
    }
}
```

### Submission

Runtime: 240 ms, faster than 45.34% of C# online submissions for Running Sum of 1d Array.

Memory Usage: 31.4 MB, less than 53.88% of C# online submissions for Running Sum of 1d Array.