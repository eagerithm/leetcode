using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /*
     * 
     **   Implement strStr().
     **
     **   Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
     **
     **   Clarification:
     **
     **   What should we return when needle is an empty string? This is a great question to ask during an interview.
     **
     **   For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().
     **
     **
     **
     **   Example 1:
     **
     **   Input: haystack = "hello", needle = "ll"
     **   Output: 2
     **   Example 2:
     **
     **   Input: haystack = "aaaaa", needle = "bba"
     **   Output: -1
     **   Example 3:
     **
     **   Input: haystack = "", needle = ""
     **   Output: 0
     */

    public class ImplementstrStr
    {
        // Way1
        /*
         ** Runtime: 144 ms, faster than 16.81% of C# online submissions for Implement strStr().
         *
         *   Memory Usage: 23.8 MB, less than 15.79% of C# online submissions for Implement strStr().
         *   public int StrStr(string haystack, string needle)
         *   {
         *    return haystack.IndexOf(needle);
         *    }
        */

        // Way2
        /** Runtime: 92 ms, faster than 20.73% of C# online submissions for Implement strStr().
         ** Memory Usage: 22.9 MB, less than 91.72% of C# online submissions for Implement strStr().
         */

        /* public int StrStr(string haystack, string needle)
        {
            if (needle.Length < 1)
                return 0;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                        break;

                    if (j == needle.Length - 1)
                        return i;
                }
            }
            return -1;
        }
        */

        // way 3
        /** 
         * Runtime: 1084 ms, faster than 17.10% of C# online submissions for Implement strStr().
         *Memory Usage: 40.4 MB, less than 5.06% of C# online submissions for Implement strStr().
         **/
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length < 1)
                return 0;

            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                var subHaystack = haystack.Substring(i, needle.Length);

                if (subHaystack == needle)
                    return i;
            }
            return -1;
        }
    }
}
