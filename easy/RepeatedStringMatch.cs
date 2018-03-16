//https://leetcode.com/problems/repeated-string-match/description/

using System.Text;

public class RepeatedStringMatchDemo {
    public int RepeatedStringMatch(string A, string B) {
        
        StringBuilder strA = new StringBuilder();
        int nCount = (int)((double)B.Length / (double)A.Length + 0.999);
        for (int i = 0; i < nCount; i++)
            strA.Append(A);

        if (strA.ToString().IndexOf(B) != -1)
            return nCount;

        if (strA.Append(A).ToString().IndexOf(B) != -1)
            return nCount + 1;

        return -1;
    }
}