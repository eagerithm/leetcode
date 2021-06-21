// 1: not supported replaceAll function on Leetcode yet.
var defangIPaddr = function (address) {
  return address.replaceAll(".", "[.]");
};

// 2
var defangIPaddr = function (address) {
  return address.split(".").join("[.]");
};

// 3
var defangIPaddr = function (address) {
  return address.replace(/\./g, "[.]");
};

// 4
var defangIPaddr = function (address) {
  return address
    .split("")
    .map((character) => (character === "." ? "[.]" : character))
    .join("");
};
