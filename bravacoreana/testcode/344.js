import testCode from "./testCode.js";

const input = ["h", "e", "l", "l", "o"];
const output = ["o", "l", "l", "e", "h"];

// 1
var reverseString = function (s) {
  return s.reverse();
};

//2
var reverseString2 = function (s) {
  let arr = Object.assign([], s);
  for (let i = 0; i < arr.length; i++) {
    arr[i] = s[s.length - i - 1];
  }
  return arr;
};

//3
var reverseString3 = function (s) {
  for (let l = 0, r = s.length - 1; l < r; l++, r--) {
    let tmp = s[l];
    s[l] = s[r];
    s[r] = tmp;
  }
  return s;
};

testCode(reverseString(input), output); // passed
testCode(reverseString2(input), output);
testCode(reverseString3(input), output);
