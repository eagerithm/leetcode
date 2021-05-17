/*Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
Example 4:

Input: s = "([)]"
Output: false
Example 5:

Input: s = "{[]}"
Output: true



Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.*/


public class Solution
{
    public bool IsValid(string s)
    {

        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (stack.Count > 0 && c == ')' && stack.Peek() == '(')
                stack.Pop();
            else if (stack.Count > 0 && c == '}' && stack.Peek() == '{')
                stack.Pop();
            else if (stack.Count > 0 && c == ']' && stack.Peek() == '[')
                stack.Pop();
            else
                stack.Push(c);
        }
        return stack.Count == 0;
    }
}

/*
## Submissions

Runtime: 68 ms, faster than 94.14% of C# online submissions for Valid Parentheses.

Memory Usage: 22.8 MB, less than 30.13% of C# online submissions for Valid Parentheses.*/