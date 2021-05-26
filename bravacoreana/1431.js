// << 1431. Kids With the Greatest Number of Candies >>

/*
Given the array candies and the integer extraCandies, 
where candies[i] represents the number of candies that the ith kid has.
For each kid check if there is a way to distribute extraCandies 
among the kids such that he or she can have the greatest number of candies among them. 
Notice that multiple kids can have the greatest number of candies.

- Example 1:
Input: candies = [2,3,5,1,3], extraCandies = 3
Output: [true,true,true,false,true] 
Explanation: 
Kid 1 has 2 candies and if he or she receives all extra candies (3) will have 5 candies --- the greatest number of candies among the kids. 
Kid 2 has 3 candies and if he or she receives at least 2 extra candies will have the greatest number of candies among the kids. 
Kid 3 has 5 candies and this is already the greatest number of candies among the kids. 
Kid 4 has 1 candy and even if he or she receives all extra candies will only have 4 candies. 
Kid 5 has 3 candies and if he or she receives at least 2 extra candies will have the greatest number of candies among the kids. 


- Example 2:
Input: candies = [4,2,1,1,2], extraCandies = 1
Output: [true,false,false,false,false] 
Explanation: There is only 1 extra candy, therefore only kid 1 will have the greatest number of candies among the kids regardless of who takes the extra candy.

-Example 3:
Input: candies = [12,1,12], extraCandies = 10
Output: [true,false,true]


* Constraints:
2 <= candies.length <= 100
1 <= candies[i] <= 100
1 <= extraCandies <= 50

*/

// ========== START FROM HERE : ========== //

/**
 * @param {number[]} candies
 * @param {number} extraCandies
 * @return {boolean[]}
 */
/*
var kidsWithCandies = function (candies, extraCandies) {};
*/

const candies1 = [2, 3, 5, 1, 3];
const extraCandies1 = 3;
const candies2 = [4, 2, 1, 1, 2];
const extraCandies2 = 1;
const candies3 = [12, 1, 12];
const extraCandies3 = 10;

// ========== START FROM HERE : ========== //

// * way 1
// Runtime: 80 ms, faster than 66.15% of JavaScript online submissions for Kids With the Greatest Number of Candies.
// Memory Usage: 39.1 MB, less than 21.80% of JavaScript online submissions for Kids With the Greatest Number of Candies.

var kidsWithCandies1 = function (candies, extraCandies) {
  return candies.map((v) => v + extraCandies >= Math.max(...candies));
};

console.log(kidsWithCandies1(candies1, extraCandies1));
console.log(kidsWithCandies1(candies2, extraCandies2));
console.log(kidsWithCandies1(candies3, extraCandies3));

// ====================================== //

// * way 2
// Runtime: 84 ms, faster than 34.53% of JavaScript online submissions for Kids With the Greatest Number of Candies.
// Memory Usage: 39.4 MB, less than 7.91% of JavaScript online submissions for Kids With the Greatest Number of Candies.

var kidsWithCandies2 = function (candies, extraCandies) {
  let newArr = [];
  candies.map((candy) =>
    newArr.push(Boolean(candy + extraCandies >= Math.max.apply(null, candies)))
  );
  return newArr;
};

console.log(kidsWithCandies2(candies1, extraCandies1));
console.log(kidsWithCandies2(candies2, extraCandies2));
console.log(kidsWithCandies2(candies3, extraCandies3));

// ====================================== //

// * way 3
// Runtime: 88 ms, faster than 13.28% of JavaScript online submissions for Kids With the Greatest Number of Candies.
// Memory Usage: 39.4 MB, less than 7.91% of JavaScript online submissions for Kids With the Greatest Number of Candies.

var kidsWithCandies3 = function (candies, extraCandies) {
  let newArr = [];
  candies.map((candy) => {
    candy + extraCandies >= Math.max(...candies)
      ? newArr.push(true)
      : newArr.push(false);
  });
  return newArr;
};

console.log(kidsWithCandies3(candies1, extraCandies1));
console.log(kidsWithCandies3(candies2, extraCandies2));
console.log(kidsWithCandies3(candies3, extraCandies3));

// ====================================== //
