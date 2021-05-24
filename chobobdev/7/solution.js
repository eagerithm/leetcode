//너무 느려서 다시 해야겠다

/**
 * @param {number} x
 * @return {number}
 */

 function rev(nu){
    reversed_num = 0;
    for (;nu > 0;){
        reversed_num *=10
        n = nu%10
        reversed_num+=n
        nu =parseInt(nu/10)     
        
    }
    return reversed_num
}

var reverse = function(x) {
    if (x<0){
        result = rev(x*-1)*-1
    } else {
        result = rev(x)
    }
    
    if( result > 2147483647 || result < -2147483648){
        return 0
    }else{
        return result
    }

};
