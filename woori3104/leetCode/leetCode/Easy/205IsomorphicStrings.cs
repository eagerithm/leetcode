using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class IsomorphicStrings
    {
        /**
         ** Given two strings s and t, determine if they are isomorphic.
         ** 
         ** Two strings s and t are isomorphic if the characters in s can be replaced to get t.
         ** 
         ** All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.
         ** 
         ** 
         ** 
         ** Example 1:
         ** 
         ** Input: s = "egg", t = "add"
         ** Output: true
         ** Example 2:
         ** 
         ** Input: s = "foo", t = "bar"
         ** Output: false
         ** Example 3:
         ** 
         ** Input: s = "paper", t = "title"
         ** Output: true
         ** 
         ** 
         ** Constraints:
         ** 
         ** 1 <= s.length <= 5 * 104
         ** t.length == s.length
         ** s and t consist of any valid ascii character.
         **/

        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            var dic = new Dictionary<char, char>();
            for (var i = 0; i < s.Length; i++)
            {
                dic.TryGetValue(s[i], out var target);
                if ((target != '\0' && target != t[i])
                    || (target == '\0' && dic.ContainsValue(t[i])))
                {
                    return false;
                }
                if (target == '\0')
                    dic[s[i]] = t[i];
            }
            return true;
        }
    }
}
