// public class Solution {
//     public int LongestPalindrome(string[] words) {
//         Dictionary<<char, int, int>, int> charCount = new Dictionary<char, int>();
//         for(int w = 0; w<words.Length; w++)
//         {
//             string word = words[w];
//             for(int i = 0; i<word.Length; i++)
//             {
//                 char c = word[i];
//                 if(!charCount.ContainsKey(<c, w,i>))
//                 {
//                     charCount.Add(<c, w, i>, 1);
//                 }
//             }




//         }
//     }
// }

public class Solution {
    public int LongestPalindrome(string[] words) {
         var multiset = new Dictionary<string, int>();
 foreach (var word in words)
 {
     if (!multiset.ContainsKey(word)) multiset[word] = 0;
     multiset[word]++;
 }

 int answer = 0;
 HashSet<string> tag = new();
 bool alreadySingle = false;

 foreach (var multisetKey in multiset.Keys)
 {
     var reversed = new string(multisetKey.Reverse().ToArray());

     // If the map contains the reversed string and the string or its reverses have not been tagged
     if (multiset.ContainsKey(reversed) && !tag.Contains(reversed))
     {

         // Tag both of them to avoid repetitions
         tag.Add(reversed);
         tag.Add(multisetKey);

         // First the case where its "aa", "bb", ..
         if (reversed[0] == reversed[1])
         {
             var reps = multiset[reversed];

             if (reps % 2 == 0)
             {
                 // If reps is even then string can be on both sides of the result string so add it full
                 answer += reps * 2;
             }
             //If not then
             else
             {
                 // Check if its already one in the middle and add the rest
                 if (alreadySingle)
                 {
                     answer += (reps - 1) * 2;
                 }
                 // If there isn't in the middle then add it full
                 else
                 {
                     alreadySingle = true;
                     answer += reps * 2;
                 }
             }
         }
         // Otherwise add the maximum amount you can repeat the string with its reversed, which is the minimum of both
         else
         {
             answer += Math.Min(multiset[reversed], multiset[multisetKey]) * 4;
         }
     }
 }

 return answer;
    }
}