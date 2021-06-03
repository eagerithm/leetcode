/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */

/*

문제 해결

target과 nums안에 값을 뺀 값을 객체의 key 값으로 저장

반복문을 돌면서 nums 배열안에 맞는 짝이 있는지 판별하기 위해

객체의 key 값 중에 현재 값이 있는지 없는지 확인

있다면 해당 값을 return

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
