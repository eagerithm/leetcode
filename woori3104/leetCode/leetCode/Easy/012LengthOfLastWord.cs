using System;
namespace LeetCode.Easy
{
    public class LengthOfLastWordClass
    {
        /*
         * LengthOfLastWord
         * Given a string s consists of some words separated by spaces, return the length of the last word in the string. If the last word does not exist, return 0.
         *
         *   A word is a maximal substring consisting of non-space characters only.
            
            Example 1:
            Input: s = "Hello World"
            Output: 5
            Example 2:
            Input: s = " "
            Output: 0
 
            Constraints:
            1 <= s.length <= 104
            s consists of only English letters and spaces ' '.
         */

        // case1
        // Runtime: 76 ms, faster than 67.28% of C# online submissions for Length of Last Word.
        // Memory Usage: 23.1 MB, less than 15.72% of C# online submissions for Length of Last Word.
        public int LengthOfLastWord(string s)
        {
            string[] strs = s.Trim().Split(' ');
            return strs[strs.Length - 1].Length;
        }

        // case2
        // Runtime: 72 ms, faster than 86.01% of C# online submissions for Length of Last Word.
        // Memory Usage: 22.4 MB, less than 95.69% of C# online submissions for Length of Last Word.

        public int LengthOfLastWord2(string s)
        {

            if (s == null || s == string.Empty)
                return 0;

            var res = 0;
            var i = s.Length - 1;

            while (i > -1 && s[i] == ' ')
                i--;

            while (i > -1 && s[i] != ' ')
            {
                res++;
                i--;
            }

            return res;
        }
    }

}