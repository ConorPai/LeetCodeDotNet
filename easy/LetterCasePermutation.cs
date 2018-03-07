//https://leetcode.com/problems/letter-case-permutation/description/

using System.Collections.Generic;

public class LetterCasePermutationDemo {
    public IList<string> LetterCasePermutation(string S) {
        
        S = S.ToLower();
        IList<string> listResult = new List<string>();

        if (S == "")
        {
            listResult.Add("");
            return listResult;
        }
        
        foreach (char item in S.ToCharArray())
        {
            int nCount = listResult.Count;

            if (nCount == 0)
            {
                if ((int)item >= 97 && (int)item <= 122)
                {
                    listResult.Add(item.ToString());
                    listResult.Add(item.ToString().ToUpper());
                }
                else
                    listResult.Add(item.ToString());
            }
            else
            {
                if ((int)item >= 97 && (int)item <= 122)
                {
                    for (int i = 0; i < nCount; i++)
                    {
                        string str = listResult[i];
                        listResult[i] += item;
                        str += item.ToString().ToUpper();
                        listResult.Add(str);
                    }
                }
                else
                {
                    for (int i = 0; i < listResult.Count; i++)
                        listResult[i] += item;
                }
            }
        }

        return listResult;
    }
}