//https://leetcode-cn.com/problems/long-pressed-name/

public class LongPressedNameDemo {
    public bool IsLongPressedName(string name, string typed) {
        char[] cName = name.ToCharArray();
        char[] cTyped = typed.ToCharArray();

        if (cName.Length == 0 || cTyped.Length == 0)
            return false;

        if (cName[0] != cTyped[0])
            return false;

        int nIndex = 0;
        for (int i = 0; i < cName.Length; i++)
        {
            if (nIndex >= cTyped.Length)
                return false;

            if (cName[i] == cTyped[nIndex])
            {
                nIndex++;
                continue;
            }

            char cLast = cTyped[nIndex - 1];
            while (cLast == cTyped[nIndex])
            {
                if (++nIndex >= cTyped.Length)
                    return false;
            }

            if (cName[i] != cTyped[nIndex++])
                return false;
        }

        return true;
    }
}