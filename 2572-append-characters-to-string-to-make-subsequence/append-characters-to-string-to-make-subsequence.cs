public class Solution {
    public int AppendCharacters(string s, string t) {
        int idxS = 0, idxT = 0;
        while(idxS < s.Length)
        {
            if(s[idxS] == t[idxT])
            {
                idxT++;
                if(idxT == t.Length){
                    return 0;
                }
            }
            idxS++;
        }
        return t.Length - idxT;
        
    }
}