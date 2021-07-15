using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class ContainsDuplicateClass
    {
        /**
         ** Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
         **
         **
         **
         ** Example 1:
         **
         ** Input: nums = [1,2,3,1]
         ** Output: true
         ** Example 2:
         **
         ** Input: nums = [1,2,3,4]
         ** Output: false
         ** Example 3:
         **
         ** Input: nums = [1,1,1,3,3,4,3,2,4,2]
         ** Output: true
         **
         **
         ** Constraints:
         **
         ** 1 <= nums.length <= 105
         ** -109 <= nums[i] <= 109
         **/

        public bool ContainsDuplicate(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    return true;
                dic.Add(nums[i], i);
            }
            return false;
        }
    }
}
