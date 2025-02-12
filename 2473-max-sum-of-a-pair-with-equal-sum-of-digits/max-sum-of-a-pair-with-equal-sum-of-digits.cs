// public class Solution {
//     public int MaximumSum(int[] nums) {
//         // int[] sumArray = new int[nums.Length];
//         // for(int = 0; i< nums.Length; i++)
//         // {
//         //     if(nums[i] < 10)
//         //     {
//         //         sumArray[i] = nums[i];
//         //     }
//         //     else
//         //     {
//         //         int temp = nums[i];
//         //         int sum = 0;
//         //         while(temp>=10)
//         //         {
//         //             sum += temp%10;
//         //             temp = temp/10;
//         //         }
//         //         sumArray[i] = sum+temp;
//         //     }
//         // }
//         // return sumArray.ToList().Where((x,y) => (x+y))

//         Dictionary<int, (int first, int second)> sumDict = new Dictionary<int, (int first, int second)>();
//         foreach(var item in nums)
//         {
//             int temp = item;
//             int sum = 0;
//             while(temp!=0)
//             {
//                 sum += item%10;
//                 temp /= 10;
//             }
//             // sum += temp;

//             if(!sumDict.ContainsKey(sum))
//             {
//                 sumDict.Add(sum, (item, 0));
//             }
//             else
//             {
//                 sumDict.TryGetValue(sum, out var pair);
//                 pair.first = Math.Max(sum, pair.first);
//                 pair.second = Math.Max(sum, pair.second);
//                 sumDict[sum] = pair;
//             }

//         }

//         int maxSum = -1;
//         foreach (var (key, value) in sumDict)
//         {
//             if (value.second != -1)
//             {
//                 maxSum = Math.Max(maxSum, value.first + value.second);
//             }
//         }

//         return maxSum;
//     }
// }

public class Solution {
    public int MaximumSum(int[] nums)
    {
         Dictionary<int, (int max, int secondMax)> dictionary = 
         new Dictionary<int, (int max, int secondMax)>();

        foreach (var num in nums)
        {
            int digitSum = SumNumber(num);
            if (dictionary.TryGetValue(digitSum, out var pair))
            {
                if (pair.max <= num)
                {
                    int temp = pair.max;
                    pair.max = num;
                    pair.secondMax = temp;
                }
                else if (pair.secondMax < num)
                {
                    pair.secondMax = num;
                }

                dictionary[digitSum] = pair;
            }
            else
            {
                dictionary.Add(digitSum, (num, -1));
            }
        }

        int maxSum = -1;
        foreach (var (key, value) in dictionary)
        {
            if (value.secondMax != -1)
            {
                maxSum = Math.Max(maxSum, value.max + value.secondMax);
            }
        }

        return maxSum;
    }

    int SumNumber(int number)
    {
        int result = 0;
        while (number != 0)
        {
            result += (number % 10);
            number /= 10;
        }

        return result;
    }
}