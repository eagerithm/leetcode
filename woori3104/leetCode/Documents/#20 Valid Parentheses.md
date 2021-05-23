# #20 Valid Parentheses

Category: Algorithms
CreatedDate: May 17, 2021 11:21 PM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/valid-parentheses/

## 20 Valid Parentheses

## Question

Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`, determine if the input string is valid.

An input string is valid if:

1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.

**Example 1:**

```
Input: s = "()"
Output: true

```

**Example 2:**

```
Input: s = "()[]{}"
Output: true

```

**Example 3:**

```
Input: s = "(]"
Output: false

```

**Example 4:**

```
Input: s = "([)]"
Output: false

```

**Example 5:**

```
Input: s = "{[]}"
Output: true

```

**Constraints:**

- `1 <= s.length <= 104`
- `s` consists of parentheses only `'()[]{}'`.

Accepted

1,425,859

Submissions

3,556,078

## Answer

```csharp
public class Solution
{
    public bool IsValid(string s) {

        Stack<char> stack = new Stack<char>();
        foreach(char c in s) { 
            if(stack.Count > 0 && c == ')' && stack.Peek() == '(')
                    stack.Pop();
            else if(stack.Count > 0 && c == '}' && stack.Peek() == '{')
                    stack.Pop();
            else if(stack.Count > 0 && c == ']' && stack.Peek() == '[')
                    stack.Pop();
            else
                stack.Push(c);
        }
        return stack.Count == 0;
    }
}
```

## Submissions

Runtime: 68 ms, faster than 94.14% of C# online submissions for Valid Parentheses.

Memory Usage: 22.8 MB, less than 30.13% of C# online submissions for Valid Parentheses.

## Reference

### 스택(Stack)의 개념

한 쪽 끝에서만 자료를 넣고 뺄 수 있는 LIFO(Last In First Out) 형식의 자료 구조

![#20%20Valid%20Parentheses%2089ad264f30cd498b835e41064e3a0a15/Untitled.png](#20%20Valid%20Parentheses%2089ad264f30cd498b835e41064e3a0a15/Untitled.png)

### C# Stack method

[Peek()](https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack.peek?view=net-5.0#System_Collections_Stack_Peek)  Returns the object at the top of the [Stack](https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-5.0) without removing it.

[Pop()](https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack.pop?view=net-5.0#System_Collections_Stack_Pop)  Removes and returns the object at the top of the [Stack](https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-5.0).

[Push(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack.push?view=net-5.0#System_Collections_Stack_Push_System_Object_)  Inserts an object at the top of the [Stack](https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-5.0).