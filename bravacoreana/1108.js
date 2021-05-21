// << 1108. Defanging an IP Address >>

/*
Given a valid (IPv4) IP address, return a defanged version of that IP address.
A defanged IP address replaces every period "." with "[.]".

Example 1:
Input: address = "1.1.1.1"
Output: "1[.]1[.]1[.]1"


Example 2:
Input: address = "255.100.50.0"
Output: "255[.]100[.]50[.]0"

Constraints:
The given address is a valid IPv4 address.

*/

// ===== START FROM HERE: ====== //
/**
 * @param {string} address
 * @return {string}
 */

const address1 = "1.1.1.1";
const address2 = "255.100.50.0";

//  var defangIPaddr = function(address) {};

// ===== START FROM HERE: ====== //

// * way 1 - not supported replaceAll function on Leetcode yet.
// var defangIPaddr = function (address) {
//   return address.replaceAll(".", "[.]");
// };

// * way 2
/*
Runtime: 76 ms, faster than 72.59% of JavaScript online submissions for Defanging an IP Address.
Memory Usage: 38.5 MB, less than 44.67% of JavaScript online submissions for Defanging an IP Address.
*/

// var defangIPaddr = function (address) {
//   return address.split(".").join("[.]");
// };

// * way 3
/*
Runtime: 76 ms, faster than 72.59% of JavaScript online submissions for Defanging an IP Address.
Memory Usage: 38.7 MB, less than 5.37% of JavaScript online submissions for Defanging an IP Address.
*/

// var defangIPaddr = function (address) {
//   return address.replace(/\./g, "[.]");
// };

// * way 4 -
/*
Runtime: 76 ms, faster than 72.59% of JavaScript online submissions for Defanging an IP Address.
Memory Usage: 38.7 MB, less than 5.37% of JavaScript online submissions for Defanging an IP Address.
*/
var defangIPaddr = function (address) {
  return address
    .split("")
    .map((character) => (character === "." ? "[.]" : character))
    .join("");
};

console.log(defangIPaddr(address1));
console.log(defangIPaddr(address2));
