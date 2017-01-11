public class Solution {
    public bool IsHappy(int n) {
        int r = 0;
        int j = 0;

        while(n>=3)
        {
                char[] ab = n.ToString().ToCharArray();
                  for(int i=0;i<ab.Count();i++)
                    {
                        j = Convert.ToInt32(ab[i].ToString());
                        r = r + j*j;
                    }
            n=r;
            r = 0;
        }
                    
      return n==1? true : false;
    }
}
