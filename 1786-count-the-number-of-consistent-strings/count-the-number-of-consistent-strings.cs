public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
       var hashSet = new HashSet<char>(allowed);
       int ans = 0;
       foreach(var word in words)
       {
        ans += word.Any(c => (!hashSet.Contains(c))) ? 0 : 1;
       }
       return ans;
    }
}