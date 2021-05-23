using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class PalindromeNumber
    {
        /*
         * ```
         *   Input: x = -121
         *   Output: false
         *   Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
         *
         *   ```
         *
         *   **Example 3:**
         *
         *   ```
         *   Input: x = 10
         *   Output: false
         *   Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
         *
         *   ```
         *
         *   **Example 4:**
         *
         *   ```
         *   Input: x = -101
         *   Output: false
         *
         *   ```
         *
         *   **Constraints:**
         *
         *   - `231 <= x <= 231 - 1`
         *
         *   **Follow up:**
         *
         *   Could you solve it without converting the integer to a string?
         *   
         */ 
        
        public bool IsPalindrome(int x)
        {
            char[] num = x.ToString().ToCharArray();

            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
