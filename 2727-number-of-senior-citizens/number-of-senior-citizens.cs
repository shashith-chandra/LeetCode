public class Solution {
    public int CountSeniors(string[] details) {
        return details.ToList().Where(x=>Convert.ToInt32(x.Substring(11,2))> 60).Count();



        // int count = 0;
        // foreach(string detail in details)
        // {
        //     //int age = Convert.ToInt32(detail.Substring(11,2));
        //     if(Convert.ToInt32(detail.Substring(11,2))>60)
        //     {
        //         count++;
        //     }
        // }
        // return count;
    }
}