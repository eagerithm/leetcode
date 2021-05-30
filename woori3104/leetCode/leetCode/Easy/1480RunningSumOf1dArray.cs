using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class RunningSumOf1dArray
    {
        /*
        ** **Example 1:**
        ** 
        ** ```
        ** Input: nums = [1,2,3,4]
        **         Output: [1,3,6,10]
        **         Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
        ** ```
        ** 
        ** **Example 2:**
        ** 
        ** ```
        ** Input: nums = [1,1,1,1,1]
        **         Output: [1,2,3,4,5]
        **         Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
        ** ```
        ** 
        ** **Example 3:**
        ** 
        ** ```
        ** Input: nums = [3,1,2,10,1]
        **         Output: [3,4,6,16,17]
        ** 
        ** ```
        ** 
        ** **Constraints:**
        ** 
        ** - `1 <= nums.length <= 1000`
        ** - `10^6 <= nums[i] <= 10^6`
        */


        public int[] RunningSum(int[] nums) {
            int sum = nums[0];

            for (int i=1; i<nums.Length; i++) {
                sum += nums[i];
                nums[i] = sum;
            }

            return nums;
        }
    }
}
