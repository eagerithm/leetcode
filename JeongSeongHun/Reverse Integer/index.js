/**
 * @param {number} x
 * @return {number}
 */
hunNam-210513

// 방법 1
const reverse = function (x) {
  const reverseNumber = (x) => {
    const text = String(x);
    if (text.includes("-")) {
      const [, ...rest] = text.split("");
      return -Number(rest.reverse().join(""));
    } else return Number(text.split("").reverse().join(""));
  };

  if (
    reverseNumber(x) < -Math.pow(2, 31) ||
    reverseNumber(x) > Math.pow(2, 31)
  ) {
    return 0;
  } else {
    return reverseNumber(x);
  }
};

// 방법 2

/**
 * @param {number} x
 * @return {number}
 */
var reverse = function (x) {
  let val = parseInt(Math.abs(x).toString().split("").reverse().join(""));
  return val > Math.pow(2, 31) ? 0 : x > 0 ? val : val * -1;
};

 let reverse = function(x) {
    const reverseNumber = function(x){
        const text = String(x);
        if(x < 0){
            const [,...rest] = text.split('');
            return -Number(rest.reverse().join(''));
        } else return Number(text.split('').reverse().join(''))
    }
    
    if(reverseNumber(x) < -Math.pow(2,31) || reverseNumber(x) > Math.pow(2,31)){
        return 0;
    } else return reverseNumber(x)
};
main
