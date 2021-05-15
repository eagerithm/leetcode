# #07 Reverse Integer

CreatedDate: May 14, 2021 7:59 PM
Difficulty: Easy
language: c#
url: https://leetcode.com/problems/reverse-integer/

```jsx
public class Solution {
    public int Reverse(int x) {

        // 입력받은 숫자의 자리수를 구함
        int digit = x.ToString().Length;
        if (x<0) 
            digit -= 1;
        // 임시 변수에 입력받은 숫자를 대임
        int temp = x;
        // 결과 반환용 변수 선언
        double result=0;
        int j = 0;
        // 입력받은 숫자의 자리수반큼 루프
        for(int i = digit-1; i> -1; i--) {
            int div=(int)Math.Pow(10, i);
            int share = temp/div;
            temp =x%div;
            result += share * Math.Pow(10, j);
            
            j++;
        }
        if (result > Math.Pow(2, 31) || result < Math.Pow(-2, 31)-1) {
            return 0;
        }
        return (int)result;
    }
}
```

### Result

Runtime: 40 ms, faster than 81.36% of C# online submissions for Reverse Integer.

Memory Usage: 15.7 MB, less than 25.71% of C# online submissions for Reverse Integer.