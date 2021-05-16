// < 1480. Running Sum of 1d Array >

/*
Given an array nums. 
We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
Return the running sum of nums.

Example 1:
Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

Example 2:
Input: nums = [1,1,1,1,1]
Output: [1,2,3,4,5]
Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].

Example 3:
Input: nums = [3,1,2,10,1]
Output: [3,4,6,16,17]

Constraints:
1 <= nums.length <= 1000
-10^6 <= nums[i] <= 10^6
*/

// ===== Start from here: ===== //

/**
 * @param {number[]} nums
 * @return {number[]}
 */
// var runningSum = function (nums) {};

const nums1 = [1, 2, 3, 4];
const nums2 = [1, 1, 1, 1, 1];
const nums3 = [3, 1, 2, 10, 1];

// - way 1
// var runningSum = function (nums) {
//   let total = 0;
//   let newArray = [];
//   for (a of nums) {
//     total += a;
//     newArray.push(total);
//   }
//   return newArray;
// };

// - way 2
/*
Runtime: 76 ms, faster than 88.53% of JavaScript online submissions for Running Sum of 1d Array.
Memory Usage: 38.7 MB, less than 84.38% of JavaScript online submissions for Running Sum of 1d Array.
*/
var runningSum = function (nums) {
  let total = 0;
  let newArray = [];
  for (let i = 0; i < nums.length; i++) {
    total += nums[i];
    newArray.push(total);
  }

  return newArray;
};

runningSum(nums1);
runningSum(nums2);
runningSum(nums3);
