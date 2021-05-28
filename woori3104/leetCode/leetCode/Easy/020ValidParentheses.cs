using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /*
     * 
     * Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`, determine if the input string is valid.
     *
     *   An input string is valid if:
     *
     *   1. Open brackets must be closed by the same type of brackets.
     *   2. Open brackets must be closed in the correct order.
     *
     *   **Example 1:**
     *
     *   ```
     *   Input: s = "()"
     *   Output: true
     *
     *   ```
     *
     *   **Example 2:**
     *
     *   ```
     *   Input: s = "()[]{}"
     *   Output: true
     *
     *   ```
     *
     *   **Example 3:**
     *
     *   ```
     *   Input: s = "(]"
     *   Output: false
     *
     *   ```
     *
     *   **Example 4:**
     *
     *   ```
     *   Input: s = "([)]"
     *   Output: false
     *
     *   ```
     *
     *   **Example 5:**
     *
     *   ```
     *   Input: s = "{[]}"
     *   Output: true
     *
     *   ```
     *
     *   **Constraints:**
     *
     *   - `1 <= s.length <= 104`
     *   - `s` consists of parentheses only `'()[]{}'`.
     */

    public class ValidParentheses
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
}
