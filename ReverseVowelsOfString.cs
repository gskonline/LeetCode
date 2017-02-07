public class Solution {
    public string[] FindWords(string[] words) {
        
        var wordsList = words.ToList();
         
         for(int i = 0; i< wordsList.Count - 1; i++)
         {
          if(CheckWord(wordsList[i])) wordsList.RemoveAt(i);
             
         }
         return wordsList.ToArray();
         
    }
    
    private bool CheckWord(string word)
    {
         List<string> strList = new List<string>(){"QWERTYUIOP","ASDFGHJKL","ZXCVBNM"};
         var wordArray =  word.ToCharArray().Distinct().ToArray();

         int j = 0;
         int homeIndex = -1;
         
          do
        {  if (strList[j].Contains(wordArray[0])) homeIndex = j;
            j++;
        } while (homeIndex < 0);
             
         for (int i = 0; i < wordArray.Length -1; i++)
         {
            if (!strList[homeIndex].Contains(wordArray[i])) return true;
             
         }
         
         
        return false;
    }
}
