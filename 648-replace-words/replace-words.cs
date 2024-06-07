public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) {
       
        string[] words = sentence.Split(" ");
        for(int i =0; i<words.Length; i++)
        {
           words[i] = CheckIfReplacable(words[i], dictionary.ToList());
        }

        return String.Join(" ", words);
        
    }
    public string CheckIfReplacable(string str, List<string> dictionary)
    {
        string ans = str;
        foreach(string root in dictionary)
        {
            int i =0;
            while(i< root.Length && i< ans.Length && str[i] == root[i])
            {
                i++;
            }
            if(i == root.Length)
            {
                ans = ans.Length > root.Length ? root : ans;
            }
        }
        return ans;


    }
}