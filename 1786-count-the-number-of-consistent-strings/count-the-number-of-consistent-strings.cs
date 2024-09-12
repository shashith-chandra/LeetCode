public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int ans = 0;

        foreach(string word in words)
        {
            var allCharExists = word.ToCharArray().All(item => (allowed.ToCharArray().Contains(item)));
            if(allCharExists) ans++;
        }
        return ans;
        
    }
}