public class Solution {
    public int MinimumDeletions(string word, int k) {
        Dictionary<char, int> charFreq = new Dictionary<char, int>();
        foreach(char c in word)
        {
            if(!charFreq.ContainsKey(c))
            {
                charFreq.Add(c, 1);
            }
            else
            {
                charFreq[c]++;
            }
        }

        int res = word.Length;
        foreach(int a in charFreq.Values)
        {
            int deleted = 0;
            foreach(int b in charFreq.Values)
            {
                if(a>b)
                {
                    deleted += b;
                }
                else if(b > a+k)
                {
                    deleted += b - (a+k);
                }
            }
            res = Math.Min(res, deleted);
        }
        return res;

        
    }
}