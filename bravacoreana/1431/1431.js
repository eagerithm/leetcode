// 1
var kidsWithCandies1 = function (candies, extraCandies) {
  return candies.map((candy) => candy + extraCandies >= Math.max(...candies));
};

// 2
var kidsWithCandies2 = function (candies, extraCandies) {
  let newArr = [];
  candies.map((candy) =>
    newArr.push(Boolean(candy + extraCandies >= Math.max.apply(null, candies)))
  );
  return newArr;
};

// 3
var kidsWithCandies3 = function (candies, extraCandies) {
  let newArr = [];
  candies.map((candy) => {
    candy + extraCandies >= Math.max(...candies)
      ? newArr.push(true)
      : newArr.push(false);
  });
  return newArr;
};
