using System;
namespace LeetCode.Easy
{
    public class MySqrtClass
    {
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
