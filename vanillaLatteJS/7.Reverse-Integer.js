/**
 * @param {number} x
 * @return {number}
 */

var reverse = function (x) {
  let isNegative = x < 0;
  const absoluteNum = Math.abs(x);
  const reversedAbs = [...(absoluteNum + "")].reverse().join("");
  if (
    (isNegative && reversedAbs > 2 ** 31) ||
    (!isNegative && reversedAbs > 2 ** 31 - 1)
  ) {
    return 0;
  }
  if (isNegative) {
    return -reversedAbs;
  } else {
    return +reversedAbs;
  }
};
