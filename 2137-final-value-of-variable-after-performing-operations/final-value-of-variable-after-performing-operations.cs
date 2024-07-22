public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int ans = 0;
        foreach(string operation in operations){
        switch(operation)
        {
            case "--X": --ans;
            break;
             case "X--": ans--;
            break;
            case "++X": ++ans;
            break;
             case "X++": ans++;
            break;
        }
        }
        return ans;
        
    }
}