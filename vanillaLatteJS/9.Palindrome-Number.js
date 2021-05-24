/**
Runtime: 208 ms, faster than 86.75% of JavaScript online submissions for Palindrome Number.
Memory Usage: 48.7 MB, less than 64.51% of JavaScript online submissions for Palindrome Number.
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function (x) {
  const absNum = Math.abs(x);
  const reversedNumStr = +[...(absNum + "")].reverse().join("");
  return x < 0 ? false : absNum === reversedNumStr;
};
