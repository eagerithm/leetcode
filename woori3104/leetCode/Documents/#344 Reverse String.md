# #344 Reverse String

Category: Algorithms
CreatedDate: May 17, 2021 10:36 PM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/reverse-string/

### Question

Write a function that reverses a string. The input string is given as an array of characters `s`.

**Example 1:**

```
Input: s = ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]

```

**Example 2:**

```
Input: s = ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]

```

**Constraints:**

- `1 <= s.length <= 105`
- `s[i]` is a [printable ascii character](https://en.wikipedia.org/wiki/ASCII#Printable_characters).

**Follow up:** Do not allocate extra space for another array. You must do this by modifying the input array [in-place](https://en.wikipedia.org/wiki/In-place_algorithm) with `O(1)` extra memory.

## Answer

```csharp
public class Solution {
    public void ReverseString(char[] s) {
        for (int i = 0; i< s.Length/2; i++) {
            var temp = s[i];
            s[i] = s[s.Length-1-i];
            s[s.Length-1-i] = temp;
        }
    }
}
```

### Submissions

Runtime: 356 ms, faster than 35.82% of C# online submissions for Reverse String.

Memory Usage: 35.4 MB, less than 71.46% of C# online submissions for Reverse String.