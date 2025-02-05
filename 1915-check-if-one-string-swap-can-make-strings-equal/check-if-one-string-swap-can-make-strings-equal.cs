public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        int count = 0;
        int first = Int32.MinValue, second = Int32.MinValue;
        for(int i =0; i< s1.Length; i++)
        {
            if(s1[i] != s2[i])
            {
                count++;
                if(count == 1)
                {
                    first = i;
                }
                else if(count == 2)
                {
                    second = i;
                }
                else
                {
                    return false;
                }
            }
        }
        if(count == 0) return true;
        if(count == 2)
        {
            if(s1[first] == s2[second] && s1[second] == s2[first]) return true;
        }
        return false;
        
    }
}