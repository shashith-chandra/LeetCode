public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower().Replace(" ", "");
        int start = 0, end = s.Length -1;
        while(start<end)
        {
            if(!isValidChar(s[start]))
            {
                start++;
            }
            else if(!isValidChar(s[end]))
            {
                end--;
            }
            else
            {
                if(s[start] == s[end])
                {
                    start++;
                    end--;
                }
                else { 
                    return false; 
                }
            }
        }
        return true;
    }
    public bool isValidChar(char ch)
    {
        return (ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9');
    }
}