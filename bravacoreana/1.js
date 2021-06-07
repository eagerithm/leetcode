// << 1. Two Sum >>
/*

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

- Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].

- Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

- Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]
 

* Constraints:
2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 
* Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
*/

// ===== START FROM HERE : ===== //

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
// var twoSum = function (nums, target) {};

const nums1 = [2, 7, 11, 5];
const target1 = 9;
const nums2 = [3, 2, 4];
const target2 = 6;
const nums3 = [3, 3];
const target3 = 6;
// ===== START FROM HERE : ===== //

// * way 1

var twoSum = function (nums, target) {
  for (let i = 0; i < nums.length; i++) {
    for (let j = i + 1; j <= nums.length; j++) {
      if (target === nums[i] + nums[j]) {
        return [i, j];
      }
    }
  }
};

console.log(twoSum(nums1, target1));
console.log(twoSum(nums2, target2));
console.log(twoSum(nums3, target3));

// * way 2

var twoSum2 = function (nums, target) {
  const dict = {};
  for (let i = 0; i < nums.length; i++) {
    const value = target - nums[i];
    if (value in dict) return [dict[value], i];
    dict[nums[i]] = i;
  }
};

console.log(twoSum2(nums1, target1));
console.log(twoSum2(nums2, target2));
console.log(twoSum2(nums3, target3));
