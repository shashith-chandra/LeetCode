public class Solution {
    public string ClearDigits(string s) {
        
        if(string.IsNullOrEmpty(s))
            return "";

        Stack<char> stack = new Stack<char>();
        foreach(var c in s)
        {
            if(Char.IsDigit(c) && stack.Count > 0 && Char.IsLetter(stack.Peek()))
                stack.Pop();
            else
                stack.Push(c);
        }

        return new string(stack.Reverse().ToArray());
    }
}