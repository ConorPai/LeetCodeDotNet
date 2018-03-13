//https://leetcode.com/problems/rotate-string/description/

public class RotateStringDemo {
    public bool RotateString(string A, string B) {
        char[] cA = A.ToCharArray();
        char[] cB = B.ToCharArray();
        for (int i = 0; i < cA.Length; i++)
        {
            if (cA[i] == cB[0])
            {
                string sTemp = A.Substring(i, A.Length - i) + A.Substring(0, i);

                if (sTemp.CompareTo(B) == 0)
                    return true;
            }
        }

        return false;
    }
}