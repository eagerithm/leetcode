/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {
  const checked = {};
  // for (let [index, num] of nums.entries()) {
  for (let index = 0; index < nums.length; index++) {
    const num = nums[index];
    const remain = target - num;
    if (checked[remain] >= 0) {
      return [index, checked[remain]];
    }
    checked[num] = index;
  }
};
