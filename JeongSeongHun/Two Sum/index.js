/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
const twoSum = function (nums, target) {
  const comp = {};
  for (let i = 0; i < nums.length; i++) {
    if (comp[nums[i]] !== undefined) {
      return [comp[nums[i]], i];
    }
    comp[target - nums[i]] = i;
  }
};
