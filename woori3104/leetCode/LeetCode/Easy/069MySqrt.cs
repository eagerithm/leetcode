using System;
namespace LeetCode.Easy
{
    public class MySqrtClass
    {
        /*
        * Given a non-negative integer x, compute and return the square root of x.
        *
        *  Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.
        *
        *  Note: You are not allowed to use any built-in exponent function or operator, such as pow(x, 0.5) or x ** 0.5.
        *
        *
        *
        *  Example 1:
        *
        *  Input: x = 4
        *  Output: 2
        *  Example 2:
        *
        *  Input: x = 8
        *  Output: 2
        *  Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.
        *
        *
        *  Constraints:
        *
        *  0 <= x <= 231 - 1
        */

        // Runtime: 44 ms, faster than 59.43% of C# online submissions for Sqrt(x).
        // Memory Usage: 15.1 MB, less than 90.57% of C# online submissions for Sqrt(x).
        public int MySqrt(int x)
        {
            if (x == 0 || x == 1)
                return x;

            int start = 0;
            int end = int.MaxValue;

            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (mid == x / mid)
                {
                    return mid;
                }
                else if (mid > x / mid)
                {
                    end = mid;
                }
                else
                {
                    start = mid;
                }
            }
            return start;
        }
    }
}
