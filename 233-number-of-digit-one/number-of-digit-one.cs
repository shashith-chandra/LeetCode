public class Solution {
    public int CountDigitOne(int n) {
        int count = 0, lower = 0, current = 0, higher = 0, factor = 1;
    
    while (factor <= n)
    {
        lower = n % factor;
        current = (n / factor) % 10;
        higher = n / (factor * 10);
        if (current == 0)
            count += higher * factor;
        else if (current == 1)
            count += higher * factor + lower + 1;
        else
            count += (higher + 1) * factor;
        
        factor *= 10;
    }
    return count;

        
    }
}