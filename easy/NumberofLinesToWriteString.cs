//https://leetcode.com/problems/number-of-lines-to-write-string/description/

using System;

public class NumberofLinesToWriteStringDemo {
    public int[] NumberOfLines(int[] widths, string S) {
        int[] ret = new int[2];
        ret[0] = 0;
        ret[1] = 0;
        foreach(char c in S.ToCharArray())
        {
            int nWidth = widths[Convert.ToInt32(c) - 97];
            if (ret[1] + nWidth > 100)
            {
                ret[0] += 1;
                ret[1] = nWidth;
            }
            else
            {
                if (ret[0] == 0)
                    ret[0] = 1;
                ret[1] += nWidth;
            }
        }

        return ret;
    }
}