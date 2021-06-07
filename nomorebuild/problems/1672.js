/**
 * @param {number[][]} accounts
 * @return {number}
 */

// 첫번째 방법 - 배열과 Math.max를 사용하는 법 //
const maximumWealth = (accounts) => {
  // 결과 반환용 배열
  const resultArray = [];

  // accounts의 길이만큼 반복
  for (let i = 0; i < accounts.length; i++) {
    // accounts 내부의 배열의 합산 변수
    let sum = 0;

    // accounts 내부의 배열만큼 반복
    for (let j = 0; j < accounts[i].length; j++) {
      // accounts내부의 배열을 반복한 값을 증감연산자로 값 지정
      sum += accounts[i][j];
    }

    // 결과 반환용 배열에 sum의 값을 추가
    resultArray.push(sum);
  }

  // Math.max함수와 Spread Operator로 최대치 반환
  return Math.max(...resultArray);
};

// 두번째 방법 - 배열과 Math.max가 아닌 변수를 지정해서 사용하는 법 //
const maximumWealth2 = (accounts) => {
  // 최대값 변수지정
  let maxValue = 0;

  // accounts의 길이만큼 반복
  for (let i = 0; i < accounts.length; i++) {
    // accounts 내부의 배열의 합산 변수
    let sum = 0;

    // accounts 내부의 배열만큼 반복
    for (let j = 0; j < accounts[i].length; j++) {
      // accounts내부의 배열을 반복한 값을 증감연산자로 값 지정
      sum += accounts[i][j];
    }

    // maxValue가 sum보다 적을 경우 maxValue값 다시 지정
    if (maxValue < sum) {
      maxValue = sum;
    }
  }

  return maxValue;
};

// 세번째 방법 - 내부함수 떡칠 //
// return Math.max(...accounts.map((customer) => customer.reduce((a,b) => a+b)));
