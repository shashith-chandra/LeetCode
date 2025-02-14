public class Solution {
    public int MaxScore(string s) {
        int ones = 0, zeroes = 0, best = int.MinValue;
        for(int i =0; i < s.Length-1; i++)
        {
            if(s[i] == '1') ones++;
            else zeroes++;

            best = Math.Max(best, zeroes-ones);
        }
        if(s[s.Length-1] == '1') ones++;
        
        return best+ones;
    }
}