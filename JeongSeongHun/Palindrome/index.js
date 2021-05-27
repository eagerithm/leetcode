/**
 * @param {number} x
 * @return {boolean}
 */
 var isPalindrome = function(x) {
    const text = String(x).split('');
    
    const arr = []
    const reverse = text.concat().reverse();
    
    for(let i = 0; i<text.length; i++){
        if(text[i] === reverse[i]) arr.push(true);
        else arr.push(false);
    }
    
    if(arr.includes(false)) return false;
    else return true
};