using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class ReverseStringClass
    {
        /*
         * 
         * Write a function that reverses a string. The input string is given as an array of characters `s`.
         *
         *   **Example 1:**
         *
         *   ```
         *   Input: s = ["h","e","l","l","o"]
         *   Output: ["o","l","l","e","h"]
         *
         *   ```
         *
         *   **Example 2:**
         *
         *   ```
         *   Input: s = ["H","a","n","n","a","h"]
         *   Output: ["h","a","n","n","a","H"]
         *
         *   ```
         *
         *   **Constraints:**
         *
         *   - `1 <= s.length <= 105`
         *   - `s[i]` is a [printable ascii character](https://en.wikipedia.org/wiki/ASCII#Printable_characters).
         *
         *   **Follow up:** Do not allocate extra space for another array. You must do this by modifying the input array [in-place](https://en.wikipedia.org/wiki/In-place_algorithm) with `O(1)` extra memory.
         * 
         */


        public void ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                var temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }
    }
}
