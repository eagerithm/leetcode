// 1
var twoSum = function (nums, target) {
  for (let i = 0; i < nums.length; i++) {
    for (let j = i + 1; j <= nums.length; j++) {
      if (target === nums[i] + nums[j]) {
        return [i, j];
      }
    }
  }
};

// 2
var twoSum2 = function (nums, target) {
  const dict = {};
  for (let i = 0; i < nums.length; i++) {
    const value = target - nums[i];
    if (value in dict) return [dict[value], i];
    dict[nums[i]] = i;
  }
};
