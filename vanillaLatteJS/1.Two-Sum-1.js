/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {
  let checked = {};
  let result;
  nums.every((num, index) => {
    const remain = target - num;
    if (checked[remain] >= 0) {
      result = [index, checked[remain]];
      return false;
    }
    checked[num] = index;
    return true;
  });
  return result;
};
