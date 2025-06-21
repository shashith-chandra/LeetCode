public class Solution {
    public int MinDeletions(string s) {
         int deletions = 0;
         Dictionary<char, int> freq = new Dictionary<char, int>();
         HashSet<int> used_frequencies = new HashSet<int>();
        foreach(char c in s)
        {
           if(freq.ContainsKey(c))
           {
            freq[c]++;
           }
           else
           {
            freq[c] = 1;
           }
        }
        
        foreach(int a in freq.Values)
        {
            int f = a;
           
            while(f > 0 && used_frequencies.Contains(f))
            {
                f--;
                deletions++;
            }
            used_frequencies.Add(f);
        }
       return deletions;
    }
}