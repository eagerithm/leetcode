using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class TwoSumClass
    {
        /**
         *   ## 1. Two Sum
         * 
         * 
         *   Given an array of integers `nums` and an integer `target`, return *indices of the two numbers such that they add up to `target`*.
         *
         *   You may assume that each input would have ***exactly* one solution**, and you may not use the *same* element twice.
         *
         *   You can return the answer in any order.
         *
         *   ### Example 1:
         *
         *   ```csharp
         *   Input: nums = [2, 7, 11, 15], target = 9
         *   Output:[0,1]
         *   Output: Because nums[0] +nums[1] == 9, we return [0, 1].
         *   ```
         *
         *   ### Example 2:
         *
         *   ```csharp
         *   Input: nums = [3, 2, 4], target = 6
         *   Output:[1,2]
         *   ```
         **/

        public int[] TwoSum(int[] nums, int target)
        {

            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                if (dic.ContainsKey(cur))
                {
                    return new int[] { dic[cur], i };
                }
                else
                {
                    dic[target - cur] = i;
                }
            }

            return new int[] { };
        }
    }
}
