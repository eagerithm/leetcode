# 35. Search Insert Position

Category: Algorithms
CreatedDate: May 23, 2021 1:21 AM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/search-insert-position/

### Descriptions

Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with `O(log n)` runtime complexity.

**Example 1:**

```
Input: nums = [1,3,5,6], target = 5
Output: 2

```

**Example 2:**

```
Input: nums = [1,3,5,6], target = 2
Output: 1

```

**Example 3:**

```
Input: nums = [1,3,5,6], target = 7
Output: 4

```

**Example 4:**

```
Input: nums = [1,3,5,6], target = 0
Output: 0

```

**Example 5:**

```
Input: nums = [1], target = 0
Output: 0

```

**Constraints:**

- `1 <= nums.length <= 104`
- `104 <= nums[i] <= 104`
- `nums` contains **distinct** values sorted in **ascending** order.
- `104 <= target <= 104`

### Answer #1

```csharp
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for (var i=0; i<nums.Length;i++) {
            if (nums[i] >= target) 
                return i;
        }
        return nums.Length;
    }
}
```

### Submissions

Runtime: 88 ms, faster than 90.20% of C# online submissions for Search Insert Position.

Memory Usage: 25.2 MB, less than 50.91% of C# online submissions for Search Insert Position.