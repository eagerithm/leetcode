# #01 Two Sum

CreatedDate: May 14, 2021 7:59 PM
Difficulty: Easy
language: c#, c++, java
url: https://leetcode.com/problems/two-sum/

## 1. Two Sum

Given an array of integers `nums` and an integer `target`, return *indices of the two numbers such that they add up to `target`*.

You may assume that each input would have ***exactly* one solution**, and you may not use the *same* element twice.

You can return the answer in any order.

### Example 1:

```csharp
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].
```

### Example 2:

```csharp
Input: nums = [3,2,4], target = 6
Output: [1,2]
```

### Answer : C#

```csharp
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // 결과반환용 변수 선언
        int[] result = new int[2];
        
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i+1; j< nums.Length; j++) {
                // 두개의 수를 더해서 target과 일치하는 경우, 결과값에 저장
                if (nums[i] + nums[j] == target) {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }
        }
        return result;
    }
}

```

## Result

Runtime: 248 ms, faster than 24.47% of C# online submissions for Two Sum.

Memory Usage: 31.8 MB, less than 36.32% of C# online submissions for Two Sum.

### Answer : CPP

```cpp
class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        vector<int> results(2);
        
        for (int i = 0; i < nums.size(); i++) {
            for (int j = i+1; j< nums.size(); j++) {
                // 두개의 수를 더해서 target과 일치하는 경우, 결과값에 저장
                if (nums[i] + nums[j] == target) {
                    results[0] = i;
                    results[1] = j;
                    break;
                }
            }
        }
        return results;        
    }
};
```

### Result

Runtime: 36 ms, faster than 13.28% of C++ online submissions for Two Sum.

Memory Usage: 8.9 MB, less than 56.11% of C++ online submissions for Two Sum.

### Answer : Java

```java
class Solution {
    public int[] twoSum(int[] nums, int target) {
        // 결과반환용 변수 선언
        int[] result = new int[2];
        
        for (int i = 0; i < nums.length; i++) {
            for (int j = i+1; j< nums.length; j++) {
                // 두개의 수를 더해서 target과 일치하는 경우, 결과값에 저장
                if (nums[i] + nums[j] == target) {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }
        }
        return result;
    }
}
```

### Result

Runtime: 11 ms, faster than 6.38% of Java online submissions for Two Sum.

Memory Usage: 38.7 MB, less than 98.11% of Java online submissions for Two Sum.