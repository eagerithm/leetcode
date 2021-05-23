# #26. Remove Duplicates from Sorted Array

Category: Algorithms
CreatedDate: May 22, 2021 11:57 PM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/remove-duplicates-from-sorted-array/

### Description

Given a sorted array *nums*, remove the duplicates **[in-place](https://en.wikipedia.org/wiki/In-place_algorithm)** such that each element appears only *once* and returns the new length.

Do not allocate extra space for another array, you must do this by **modifying the input array [in-place](https://en.wikipedia.org/wiki/In-place_algorithm)** with O(1) extra memory.

**Clarification:**

Confused why the returned value is an integer but your answer is an array?

Note that the input array is passed in by **reference**, which means a modification to the input array will be known to the caller as well.

Internally you can think of this:

```
//nums is passed in by reference. (i.e., without making a copy)
int len = removeDuplicates(nums);

// any modification tonums in your function would be known by the caller.
// using the length returned by your function, it prints the firstlen elements.
for (int i = 0; i < len; i++) {
    print(nums[i]);
}
```

### Answer C#

```csharp
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        if (nums.Length < 2)
            return nums.Length;
        int c = 0;
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1])
                nums[c++] = nums[i - 1];
            if (i==nums.Length-1)
                nums[c++] = nums[nums.Length-1];
        }
        return c;
    }
}
```

### Submissions

Runtime: 288 ms, faster than 13.62% of C# online submissions for Remove Duplicates from Sorted Array.

Memory Usage: 33.8 MB, less than 96.19% of C# online submissions for Remove Duplicates from Sorted Array.