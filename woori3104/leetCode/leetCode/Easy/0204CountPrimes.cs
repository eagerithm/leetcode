using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class CountPrimesClass
    {
        /*
         **    Count the number of prime numbers less than a non-negative number, `n`.
         **
         **   **Example 1:**
         **
         **   ```
         **   Input: n = 10
         **   Output: 4
         **   Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
         **
         **   ```
         **
         **   **Example 2:**
         **
         **   ```
         **   Input: n = 0
         **   Output: 0
         **
         **   ```
         **
         **   **Example 3:**
         **
         **   ```
         **   Input: n = 1
         **   Output: 0
         **
         **   ```
         **
         **   **Constraints:**
         **
         **   - `0 <= n <= 5 * 106`
          */

        /*        // Way1 : Time Limit
                public int CountPrimes(int n)
                {
                    if (n < 3) return 0;
                    List<int> primes = new List<int>();
                    primes.Add(2);
                    for (var i = 2; i < n; i++)
                    {
                        for (var j = 0; j < primes.Count; j++)
                        {
                            if (i % primes[j] == 0)
                                break;
                            if (j + 1 % primes[j] == primes.Count)
                            {
                                primes.Add(i);
                            }
                        }
                    }
                    return primes.Count;
                }*/

        // way2
        // Runtime: 104 ms, faster than 36.42% of C# online submissions for Count Primes.
        // Memory Usage: 22.5 MB, less than 59.07% of C# online submissions for Count Primes.
        public int CountPrimes(int n)
        {
            if (n < 3) return 0;
            bool[] nums = new bool[n];
            for (int i = 2; i < n; i++)
                nums[i] = true;

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (!nums[i])
                    continue;
                for (int j = i * 2; j < n; j += i)
                {
                    nums[j] = false;
                }
            }
            var res = 0;
            for (int i = 1; i < n; i++)
            {
                if (nums[i])
                    res++;
            }
            return res;
        }
    }
}
