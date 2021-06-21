// * 1
var reverseString = function (s) {
  return s.reverse();
};

// * 2: wrong answer!
var reverseString = function (s) {
  let arr = Object.assign([], s);
  for (let i = 0; i < arr.length; i++) {
    arr[i] = s[s.length - i - 1];
  }
  return arr;
};

// * 3
function reverseString(s) {
  for (let l = 0, r = s.length - 1; l < r; l++, r--) {
    let tmp = s[l];
    s[l] = s[r];
    s[r] = tmp;
  }
}
