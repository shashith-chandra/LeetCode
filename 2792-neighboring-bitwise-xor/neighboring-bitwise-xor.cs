public class Solution {
    public bool DoesValidArrayExist(int[] derived) {

        int xor = 0;
        foreach(int num in derived)
        {
            xor ^= num;
        }
        return xor == 0;
        
    }
}

