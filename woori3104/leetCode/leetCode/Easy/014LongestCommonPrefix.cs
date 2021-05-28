using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class LongestCommonPrefixClass
    {
        public string LongestCommonPrefix(string[] strs)
        {
            /*
             * Write a function to find the longest common prefix string amongst an array of strings.
             *
             *   If there is no common prefix, return an empty string `""`.
             *
             *   **Example 1:**
             *
             *   ```
             *   Input: strs = ["flower","flow","flight"]
             *   Output: "fl"
             *
             *   ```
             *
             *   **Example 2:**
             *
             *   ```
             *   Input: strs = ["dog","racecar","car"]
             *   Output: ""
             *   Explanation: There is no common prefix among the input strings.
             *
             *   ```
             *
             *   **Constraints:**
             *
             *   - `1 <= strs.length <= 200`
             *   - `0 <= strs[i].length <= 200`
             *   - `strs[i]` consists of only lower-case English letters.
             */

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
}
