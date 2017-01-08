using System.Text;
using System.Collections;

public class Solution {
    public string ReverseVowels(string s) {
var arrStr = s.ToCharArray();
string str = "aeiouAEIOU"; 
ArrayList arList = new ArrayList();
StringBuilder sb = new StringBuilder();
for (int i=0;i<arrStr.Length;i++)
{
    if(str.Contains(arrStr[i]))
    {
        sb.Append("*");
        arList.Add(arrStr[i]);
    }
    else
    {
       sb.Append(s.Substring(i,1)) ;
    }
}
for (int i = 0; i<arList.Count;i++)
{
    sb.Insert(sb.ToString().IndexOf("*"),arList[arList.Count -1 - i]);
    sb.Remove(sb.ToString().IndexOf("*"),1);
}
return sb.ToString();
    }
}
