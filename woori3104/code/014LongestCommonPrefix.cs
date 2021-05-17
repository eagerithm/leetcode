/*## Question

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string `""`.

**Example 1:**

```
Input: strs = ["flower", "flow", "flight"]
Output: "fl"

```

**Example 2:**

```
Input: strs = ["dog", "racecar", "car"]
Output: ""
Explanation: There is no common prefix among the input strings.

```

**Constraints:**

- `1 <= strs.length <= 200`
- `0 <= strs[i].length <= 200`
- `strs[i]` consists of only lower-case English letters.

### Answer #1
*/

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {

        var result = "";
        if (strs.Length == 1)
            return strs[0];

        for (int i = 0; i < strs[0].Length; i++)
        {
            var pref = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i > strs[j].Length - 1 || j == strs.Length || strs[j][i] != pref)
                    return result;
                if (j == strs.Length - 1)
                    result += pref;
            }
        }
        return result;
    }
}
/*
### Submissions

Runtime: 96 ms, faster than 89.80% of C# online submissions for Longest Common Prefix.

Memory Usage: 25.3 MB, less than 72.67% of C# online submissions for Longest Common Prefix.

Next challenges:

### Answer #2

```csharp
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {

        String result = "";
        if (strs.Length == 1)
            return strs[0];

        for (int i = 0; i < strs[0].Length + 1; i++)
        {
            string pref = strs[0].Substring(0, i);
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j].StartsWith(pref))
                {
                    if (j == strs.Length - 1)
                    {
                        result = pref;
                    }
                    continue;
                }
                break;
            }
        }
        return result;
    }
}
```

### Submission

Runtime: **136 ms**

Memory Usage: **25.9 MB * **/