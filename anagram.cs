public class Solution {
     public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var sList = s.ToCharArray().ToList();
            var tList = t.ToCharArray().ToList();
            sList.Sort();
            tList.Sort();
            for (int i = 0; i < s.Length; i++ )
            { 
                if (sList[i]  != tList[i] ) return false;
            }
            return true;
        }
}
