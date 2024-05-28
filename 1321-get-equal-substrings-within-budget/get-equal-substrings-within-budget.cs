public class Solution {
    public int EqualSubstring(string s, string t, int maxCost) {
        int[] count = new int[s.Length];
        for(int i=0; i<s.Length; i++)
        {
            count[i] = Math.Abs(s[i]- t[i]);
        }
        int ans = 0, temp = 0, right = 0, left = 0;

        while(right<count.Length)
        {
            temp += count[right];
            while(temp>maxCost)
            {
                temp -= count[left];
                left++;
            }
            ans = Math.Max(ans, right-left+1);
            right++;
        }
        return ans;
        
    }
}