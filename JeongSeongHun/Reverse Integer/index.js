/**
 * @param {number} x
 * @return {number}
 */
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