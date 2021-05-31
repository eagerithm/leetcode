/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */

const twoSum = (nums, target) => {
  const storage = {};

  for (let i = 0; i < nums.length; i++) {
    if (storage[nums[i]] !== undefined) {
      return [storage[nums[i]], i];
    }

    storage[target - nums[i]] = i;
  }
};
