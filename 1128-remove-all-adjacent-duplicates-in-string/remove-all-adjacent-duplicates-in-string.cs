public class Solution {
    public string RemoveDuplicates(string s) {
        string ans = "";
        Stack st = new Stack();
       for(int i = 0; i< s.Length; i++)
       {
        if(st.Count>0 && (char)st.Peek() == (char)s[i])
        {
            st.Pop();
        }
        else
        {
            st.Push(s[i]);
        }
       }
    Stack st2 = new Stack();
    foreach(char c in st)
    {
       st2.Push(c);
    }
       foreach(char c in st2)
       {
        ans += c;
       }
       return ans;
        
    }
}