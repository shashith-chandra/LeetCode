public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int[] C = new int[A.Length];

        for(int i = 0; i< A.Length; i++)
        {
            if(!freq.ContainsKey(A[i]))
            {
                freq.Add(A[i], 1);
            }
            else
            {
                freq[A[i]]++;
            }

            if(!freq.ContainsKey(B[i]))
            {
                freq.Add(B[i], 1);
            }
            else
            {
                freq[B[i]]++;
            }

            C[i] = freq.Where(x=>x.Value == 2).Count(); 
        }

        return C;
        
    }
}