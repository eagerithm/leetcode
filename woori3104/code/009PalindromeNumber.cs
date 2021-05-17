/*Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

 

Example 1:

Input: x = 123
Output: 321
Example 2:

Input: x = -123
Output: -321
Example 3:

Input: x = 120
Output: 21
Example 4:

Input: x = 0
Output: 0



Constraints:

-231 <= x <= 231 - 1*/


public class Solution
{
    public bool IsPalindrome(int x)
    {
        char[] num = x.ToString().ToCharArray();

        for (int i = 0; i < x / 2; i++)
        {
            if (num[i] != num[num.Length - 1 - i])
                return false;
        }
        return true;
    }
}
/*
### Result

Runtime: 40 ms, faster than 81.36% of C# online submissions for Reverse Integer.

Memory Usage: 15.7 MB, less than 25.71% of C# online submissions for Reverse Integer.*/