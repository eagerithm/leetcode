// 1
var runningSum1 = function (nums) {
  let total = 0;
  let newArray = [];
  for (a of nums) {
    total += a;
    newArray.push(total);
  }
  return newArray;
};

// 2
var runningSum2 = function (nums) {
  let total = 0;
  let newArray = [];
  for (let i = 0; i < nums.length; i++) {
    total += nums[i];
    newArray.push(total);
  }

  return newArray;
};

// 3
var runningSum3 = function (nums) {
  for (let i = 0; i < nums.length; i++) {
    i === 0 ? (nums[i] = nums[i]) : (nums[i] = nums[i - 1] + nums[i]);
    console.log(nums);
  }
};
