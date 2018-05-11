//https://leetcode-cn.com/problems/number-of-segments-in-a-string/description/

public class NumberofSegmentsinaStringDemo {
    public int CountSegments(string s) {
        int nCount = 0;
        bool bLastIsSpace = true;
        foreach (char c in s.ToCharArray())
        {
            if (c == ' ')
            {
                if (!bLastIsSpace)
                    nCount++;
                
                bLastIsSpace = true;
            }
            else
                bLastIsSpace = false;
            
        }

        if (!bLastIsSpace)
            nCount++;

        return nCount;
    }
}