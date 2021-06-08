var maximumWealth = function (accounts) {
  let max = 0;
  accounts.forEach((account) => {
    let sum = 0;
    for (a of account) {
      sum += a;
    }
    if (sum > max) max = sum;
  });
  return max;
};
