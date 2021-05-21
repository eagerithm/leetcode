/*
 < 344. Reverse String >

 Write a function that reverses a string. The input string is given as an array of characters s.

Example 1:
Input: s = ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]

Example 2:
Input: s = ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]

Constraints:
1 <= s.length <= 105
s[i] is a printable ascii character.


Follow up: Do not allocate extra space for another array. 
You must do this by modifying the input array in-place with O(1) extra memory.
*/

// ===== start from here: ===== //

/**
 * @param {character[]} s
 * @return {void} Do not return anything, modify s in-place instead.
 */

// var reverseString = function (s) { };

const s1 = ["h", "e", "l", "l", "o"];
const s2 = ["H", "a", "n", "n", "a", "h"];

// * 1
// var reverseString = function (s) {
//   return s.reverse();
// };

// * 2: different answer between leetcode and vscode, why!?
// var reverseString = function (s) {
//   let arr = Object.assign([], s);
//   for (let i = 0; i < arr.length; i++) {
//     arr[i] = s[s.length - i - 1];
//   }
//   return arr;
// };

// * 3
function reverseString(s) {
  for (let l = 0, r = s.length - 1; l < r; l++, r--) {
    let tmp = s[l];
    s[l] = s[r];
    s[r] = tmp;
  }
}
// console.log(reverseString(s1)); //[ 'o', 'l', 'l', 'e', 'h' ]
// console.log(reverseString(s2)); //[ 'h', 'a', 'n', 'n', 'a', 'H' ]

console.log(reverseString(s1));
console.log(reverseString(s2));
