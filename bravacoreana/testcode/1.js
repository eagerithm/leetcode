import testCode from "./testCode.js";

let nums = [2, 7, 11, 15];
let target = 9;

var twoSum = function (nums, target) {
  for (let i = 0; i < nums.length; i++) {
    for (let j = i + 1; j <= nums.length; j++) {
      if (target === nums[i] + nums[j]) {
        return [i, j];
      }
    }
  }
};

testCode(twoSum(nums, target), [0, 1], "1.");
