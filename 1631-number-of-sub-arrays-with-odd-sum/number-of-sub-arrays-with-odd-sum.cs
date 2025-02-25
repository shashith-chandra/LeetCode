// public class Solution {
//     public int NumOfSubarrays(int[] arr) {
        
//         // int count = 0;
//         // for(int i = 0; i< arr.Length; i++)
//         // {
//         //     int temp = arr[i];
//         //     if(temp%2 ==1)
//         //     count++;
//         //     for(int j = i+1; j<arr.Length; j++)
//         //     {
//         //         temp += arr[j];
//         //         if(temp%2 ==1)
//         //         count++;
//         //     }
//         // }
//         // return count;
//         // long mod = 1_000_000_0007;
//         // long count = 0, prefixSum = 0;
//         // int oddCount = 0, evenCount = 1;

//         // foreach(int num in arr)
//         // {
//         //     prefixSum += num;

//         //     if(prefixSum % 2 == 0)
//         //     {
//         //         count += oddCount;
//         //         evenCount++;
//         //     }
//         //     else
//         //     {
//         //         count += evenCount;
//         //         oddCount++;
//         //     }
//         //     count %= mod;
//         // }

//         // return (int)count;
//     }
// }

public class Solution {
    public int NumOfSubarrays(int[] arr) {
        const int MOD = 1000000007;
        long oddCount = 0; // Count of odd prefix sums
        long evenCount = 1; // Count of even prefix sums (initially 1 for the empty prefix)
        long currentSum = 0; // Current prefix sum
        long oddSubarrayCount = 0; // Total count of subarrays with odd sums

        foreach (int num in arr) {
            currentSum += num;

            // Check if the current prefix sum is odd or even
            if (currentSum % 2 == 0) {
                // Current sum is even
                oddSubarrayCount = (oddSubarrayCount + oddCount) % MOD;
                evenCount++; // Increment the count of even prefix sums
            } else {
                // Current sum is odd
                oddSubarrayCount = (oddSubarrayCount + evenCount) % MOD;
                oddCount++; // Increment the count of odd prefix sums
            }
        }

        return (int)oddSubarrayCount; // Return the result as an integer
    }

}