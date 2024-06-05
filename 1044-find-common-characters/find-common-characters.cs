public class Solution {
    public IList<string> CommonChars(string[] words) {
        
        int[] freq;
        int[] freq2;
        freq = getFreqArray(words[0]);
        for(int i=0; i<words.Length; i++)
        {
            freq2 = getFreqArray(words[i]);
            for(int j=0; j<26; j++)
            {
                freq[j] = Math.Min(freq[j], freq2[j]);
            }
        }

        List<string> ans = new List<string>();
        for(int i =0; i<26; i++)
        {
            while(freq[i]>0)
            {
                ans.Add(Convert.ToString((char)('a' + i)));
                freq[i]--;
            }
        }
        return ans;
    }
    public int[] getFreqArray(string word)
    {
        int[] freq = new int[26];
        for(int i=0; i< word.Length; i++)
        {
            freq[word[i]-'a'] += 1;
        }
        return freq;
    }
}