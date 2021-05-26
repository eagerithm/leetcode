/*
 * @param {number[]} nums
 * @return {number}
 */
const removeDuplicates = (nums) => {
  let prevNum = null;
  for (let i = 0; i < nums.length; i++) {
    if (prevNum === nums[i]) {
      nums.splice(i, 1);
      i--;
    }
    prevNum = nums[i];
  }

  return nums.length;
};
