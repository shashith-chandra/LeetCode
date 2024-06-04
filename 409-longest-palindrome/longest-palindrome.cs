public class Solution {
    public int LongestPalindrome(string s) {
        int ans = 0;
        Dictionary<char, int> charSet = new Dictionary<char, int>();
        for(int i = 0; i< s.Length; i++)
        {
            if(!charSet.ContainsKey(s[i]))
            {
                charSet.Add(s[i], 1);
            }
            else
            {
                int value = 0;
                charSet.TryGetValue(s[i], out value);
                value++;
                if(value%2 == 0)
                {
                    ans += value;
                    charSet.Remove(s[i]);
                }
            }
        }
         if(charSet.Any()) ans++;
         return ans;
    }
}