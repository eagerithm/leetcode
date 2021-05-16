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

var reverseString = function (s) {
  return s.reverse();
};

console.log(reverseString(s1)); //[ 'o', 'l', 'l', 'e', 'h' ]
console.log(reverseString(s2)); //[ 'h', 'a', 'n', 'n', 'a', 'H' ]
