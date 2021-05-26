// << 1480. Running Sum of 1d Array >>

/*
Given an array nums. 
We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
Return the running sum of nums.

- Example 1:
Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

- Example 2:
Input: nums = [1,1,1,1,1]
Output: [1,2,3,4,5]
Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].

- Example 3:
Input: nums = [3,1,2,10,1]
Output: [3,4,6,16,17]

Constraints:
1 <= nums.length <= 1000
-10^6 <= nums[i] <= 10^6
*/

// ========== START FROM HERE: ========== //

/**
 * @param {number[]} nums
 * @return {number[]}
 */
// var runningSum = function (nums) {};

const nums1 = [1, 2, 3, 4];
const nums2 = [1, 1, 1, 1, 1];
const nums3 = [3, 1, 2, 10, 1];

// ========== START FROM HERE: ========== //

// - way 1
var runningSum1 = function (nums) {
  let total = 0;
  let newArray = [];
  for (a of nums) {
    total += a;
    newArray.push(total);
  }
  return newArray;
};

runningSum1(nums1);
runningSum1(nums2);
runningSum1(nums3);

// - way 2
/*
Runtime: 76 ms, faster than 88.53% of JavaScript online submissions for Running Sum of 1d Array.
Memory Usage: 38.7 MB, less than 84.38% of JavaScript online submissions for Running Sum of 1d Array.
*/
var runningSum2 = function (nums) {
  let total = 0;
  let newArray = [];
  for (let i = 0; i < nums.length; i++) {
    total += nums[i];
    newArray.push(total);
  }

  return newArray;
};

runningSum2(nums1);
runningSum2(nums2);
runningSum2(nums3);

// - way 3

/*
Runtime: 80 ms, faster than 69.63% of JavaScript online submissions for Running Sum of 1d Array.
Memory Usage: 39 MB, less than 47.69% of JavaScript online submissions for Running Sum of 1d Array.
*/

var runningSum3 = function (nums) {
  for (let i = 0; i < nums.length; i++) {
    i === 0 ? (nums[i] = nums[i]) : (nums[i] = nums[i - 1] + nums[i]);
    console.log(nums);
  }
};

runningSum3(nums1);
runningSum3(nums2);
runningSum3(nums3);
