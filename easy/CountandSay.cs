//https://leetcode-cn.com/problems/count-and-say/description/

using System.Text;

public class CountandSayDemo {
    public string CountAndSay(int n) {
        string sCurrent = "1";
        StringBuilder sbResult = new StringBuilder();

        while (--n > 0)
        {
            sbResult.Clear();
            char[] cs = sCurrent.ToCharArray();

            char curChar = cs[0];
            int curCount = 1;
            for (int i = 1; i < cs.Length; i++)
            {
                if (cs[i] == curChar)
                    curCount++;
                else
                {
                    sbResult.Append(curCount.ToString());
                    sbResult.Append(curChar);

                    curChar = cs[i];
                    curCount = 1;
                }
            }

            sbResult.Append(curCount.ToString());
            sbResult.Append(curChar);
            sCurrent = sbResult.ToString();
        }

        return sCurrent;
    }
}