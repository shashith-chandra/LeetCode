public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] ans = new int[temperatures.Length];
        for(int i = 0; i< temperatures.Length; i++)
        {
            int count = 0;
             ans[i] = count;
            for(int k = i+1; k< temperatures.Length; k++)
            {
                count++;
                if(temperatures[k] > temperatures[i])
                {
                    ans[i] = count;
                    break;
                }
            }
        }
        return ans;
    }
}