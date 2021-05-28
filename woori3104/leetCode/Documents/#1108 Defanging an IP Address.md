# #1108 Defanging an IP Address

Category: Algorithms
CreatedDate: May 18, 2021 6:33 PM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/defanging-an-ip-address/

## Description

Given a valid (IPv4) IP `address`, return a defanged version of that IP address.

A *defanged IP address* replaces every period `"."` with `"[.]"`.

**Example 1:**

```
Input: address = "1.1.1.1"
Output: "1[.]1[.]1[.]1"

```

**Example 2:**

```
Input: address = "255.100.50.0"
Output: "255[.]100[.]50[.]0"

```

**Constraints:**

- The given `address` is a valid IPv4 address.

## Answer

```csharp
public class Solution {
    public string DefangIPaddr(string address) {
        return address.Replace(".","[.]");
    }
}
```

## Submission

Runtime: 64 ms, faster than 100.00% of C# online submissions for Defanging an IP Address.

Memory Usage: 23.1 MB, less than 79.80% of C# online submissions for Defanging an IP Address.

Next challenges:

### Answer2

```csharp
public class Solution {
    public string DefangIPaddr(string address) {
        var result = "";
        for (int i =0; i<address.Length; i++) {
            if (address[i] == '.')
                result += "[.]";
            else 
                result += address[i];
        }
        return result;
    }
}
```

### Submission

Runtime: 80 ms, faster than 81.53% of C# online submissions for Defanging an IP Address.

Memory Usage: 22.9 MB, less than 96.82% of C# online submissions for Defanging an IP Address.