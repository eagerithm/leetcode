public class Solution
{
    public bool IsPalindrome(int x)
    {
        char[] num = x.ToString().ToCharArray();

        for (int i = 0; i < num.Length / 2; i++)
        {
            if (num[i] != num[num.Length - 1 - i])
                return false;
        }
        return true;
    }
}