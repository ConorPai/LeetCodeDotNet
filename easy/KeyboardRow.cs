//https://leetcode.com/problems/keyboard-row/description/

using System.Collections.Generic;

public class KeyboardRowDemo {
    private List<string> m_strKeybord = new List<string>(){"qwertyuiop", "asdfghjkl", "zxcvbnm"};
    public string[] FindWords(string[] words) {
        List<string> strResult = new List<string>();

        foreach (string str in words)
        {
            int nIndex = -1;
            bool bSameRow = true;
            char[] chars = str.ToLower().ToCharArray();
            foreach(char c in chars)
            {
                if (nIndex == -1)
                {
                    for(int i = 0; i < m_strKeybord.Count; i++)
                    {
                        if (m_strKeybord[i].IndexOf(c) != -1)
                        {
                            nIndex = i;
                            break;
                        }
                    }

                    if (nIndex == -1)
                    {
                        bSameRow = false;
                        break;
                    }
                }
                else
                {
                    if (m_strKeybord[nIndex].IndexOf(c) == -1)
                    {
                        bSameRow = false;
                        break;
                    }
                }
            }

            if (bSameRow)
                strResult.Add(str);
        }

        return strResult.ToArray();
    }
}