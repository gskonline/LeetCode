using System.Text;

public class Solution {
    public string ReverseString(string s) {
        StringBuilder sb = new StringBuilder();
        int l = s.Length;
        
        for(int i=0;i<s.Length;i++)
        {
            sb.Append(s.Substring(l-1,1));
            l=l-1;
        }
        
        return sb.ToString();
    }
}
