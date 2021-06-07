/**
 * @param {number} x
 * @return {boolean}
 */

//방법 1
const isPalindrome = function (x) {
  const text = String(x).split("");

  const arr = [];
  const reverse = text.concat().reverse();

  for (let i = 0; i < text.length; i++) {
    if (text[i] === reverse[i]) arr.push(true);
    else arr.push(false);
  }

  if (arr.includes(false)) return false;
  else return true;
};

//방법 2
const isPalindrome = function (x) {
  return x === Number(x.toString().split("").reverse().join(""));
};

//방법 3
const isPalindrome = (x) => {
  if (x < 0 || (x % 10 === 0 && x !== 0)) {
    return false;
  }

  return x === reverse(x);
};

const reverse = (num) => {
  let rev = 0;

  while (num != 0) {
    rev = rev * 10 + (num % 10);
    num = parseInt(num / 10, 10);
  }

  return rev;
};
