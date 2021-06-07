/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function (nums) {
  // Hash map을 위한 Object 생성
  const hashMap = {};
  // 하나만 있는 값을 반환하기 위한 변수
  let singleValue = 0;

  // nums만큼 반복
  for (let i = 0; i < nums.length; i++) {
    // 배열일 경우 그대로 i를 push
    if (Array.isArray(hashMap[nums[i]]) && hashMap[nums[i]] !== undefined) {
      hashMap[nums[i]].push(i);
    } else {
      // 배열이 아닐 경우 새로운 배열과 함께 i추가
      hashMap[nums[i]] = [i];
    }
  }

  // HashMap에서 Object.keys를 통해 index값을 뽑아낸 뒤 forEach로 반복
  Object.keys(hashMap).some((element) => {
    // 중복되지 않는 수를 판별하기 위해 1이하 숫자를 조건문으로 걸러내고 singleValue 변수 지정
    if (hashMap[element].length <= 1) {
      singleValue = element;
    }
  });

  // 모든 연산이 끝나면 singleValue를 반환
  return singleValue;
};
