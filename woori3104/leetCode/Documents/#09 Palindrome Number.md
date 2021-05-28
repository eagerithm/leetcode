# #09 Palindrome Number

Category: Algorithms
CreatedDate: May 14, 2021 7:59 PM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/palindrome-number/

Given an integer `x`, return `true` if `x` is palindrome integer.

An integer is a **palindrome** when it reads the same backward as forward. For example, `121` is palindrome while `123` is not.

**Example 1:**

```
Input: x = 121
Output: true

```

**Example 2:**

```
Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

```

**Example 3:**

```
Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

```

**Example 4:**

```
Input: x = -101
Output: false

```

**Constraints:**

- `231 <= x <= 231 - 1`

**Follow up:**

Could you solve it without converting the integer to a string?

### c# Answer

```csharp
public class Solution {
    public bool IsPalindrome(int x) {
        char[] num = x.ToString().ToCharArray();
        
        for (int i =0; i < num.Length / 2; i++) {
            if (num[i] != num[num.Length -1 - i])
                return false;
        }
        return true;
    }
}
```

### Result

Runtime: 60 ms, faster than 80.36% of C# online submissions for Palindrome Number.

Memory Usage: 17.7 MB, less than 29.22% of C# online submissions for Palindrome Number.