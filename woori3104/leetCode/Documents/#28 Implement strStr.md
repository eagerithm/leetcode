# #28. Implement strStr()

Category: Algorithms
CreatedDate: May 23, 2021 12:25 AM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/implement-strstr/

### Description

Implement [strStr()](http://www.cplusplus.com/reference/cstring/strstr/).

Return the index of the first occurrence of needle in haystack, or `-1` if `needle` is not part of `haystack`.

**Clarification:**

What should we return when `needle` is an empty string? This is a great question to ask during an interview.

For the purpose of this problem, we will return 0 when `needle` is an empty string. This is consistent to C's [strstr()](http://www.cplusplus.com/reference/cstring/strstr/) and Java's [indexOf()](https://docs.oracle.com/javase/7/docs/api/java/lang/String.html#indexOf(java.lang.String)).

**Example 1:**

```
Input: haystack = "hello", needle = "ll"
Output: 2

```

**Example 2:**

```
Input: haystack = "aaaaa", needle = "bba"
Output: -1

```

**Example 3:**

```
Input: haystack = "", needle = ""
Output: 0

```

**Constraints:**

- `0 <= haystack.length, needle.length <= 5 * 104`
- `haystack` and `needle` consist of only lower-case English characters.

### Answer #1

단순히 c#스트링함수를 사용해서 인덱스를 반환하는 방법

```csharp
public class Solution {
    public int StrStr(string haystack, string needle) {

        return haystack.IndexOf(needle);
    }
}
```

### Submissions

Runtime: 144 ms, faster than 16.81% of C# online submissions for Implement strStr().

Memory Usage: 23.8 MB, less than 15.79% of C# online submissions for Implement strStr().

### Answer #2

```csharp
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle.Length < 1) 
            return 0;
        
        for(int i=0; i<= haystack.Length - needle.Length; i++)
        {
            for(int j=0; j<needle.Length; j++)
            {
                if(haystack[i+j] != needle[j])
                    break;
                
                if(j == needle.Length-1)
                    return i;
            }
        }
        return -1; 
    }
}
```

### Submissions

Runtime: 92 ms, faster than 20.73% of C# online submissions for Implement strStr().

Memory Usage: 22.9 MB, less than 91.72% of C# online submissions for Implement strStr().