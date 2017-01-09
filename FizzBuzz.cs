public class Solution {
    public IList<string> FizzBuzz(int n) {
      
      List<string> lstRtnVal = new List<string>();  
        for(int i=1;i<=n;i++)
        {
            if(i%3 == 0 && i%5 == 0)
                { lstRtnVal.Add("FizzBuzz");}
            else if (i%3 == 0)
            { lstRtnVal.Add("Fizz");}
            else if (i%5 == 0){ lstRtnVal.Add("Buzz");}
            else {lstRtnVal.Add(i.ToString());}
        }
       return lstRtnVal; 
    }
}
