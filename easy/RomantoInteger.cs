//https://leetcode-cn.com/problems/roman-to-integer/

public class RomantoIntegerDemo {
    public int RomanToInt(string s) {
        int nRet = 0;

        char[] cs = s.ToCharArray();

        for (int i = 0; i < cs.Length; i++)
        {
            switch (cs[i])
            {
                case 'M':
                    nRet += 1000;
                    break;
                case 'D':
                    nRet += 500;
                    break;
                case 'L':
                    nRet += 50;
                    break;
                case 'V':
                    nRet += 5;
                    break;
                case 'C':
                {
                    if (i < cs.Length - 1 && cs[i + 1] == 'D')
                    {
                        nRet += 400;
                        i++;
                    }
                    else if (i < cs.Length - 1 && cs[i + 1] == 'M')
                    {
                        nRet += 900;
                        i++;
                    }
                    else
                        nRet += 100;
                    break;
                }
                case 'X':
                {
                    if (i < cs.Length - 1 && cs[i + 1] == 'L')
                    {
                        nRet += 40;
                        i++;
                    }
                    else if (i < cs.Length - 1 && cs[i + 1] == 'C')
                    {
                        nRet += 90;
                        i++;
                    }
                    else
                        nRet += 10;
                    break;
                }
                case 'I':
                {
                    if (i < cs.Length - 1 && cs[i + 1] == 'V')
                    {
                        nRet += 4;
                        i++;
                    }
                    else if (i < cs.Length - 1 && cs[i + 1] == 'X')
                    {
                        nRet += 9;
                        i++;
                    }
                    else
                        nRet += 1;
                    break;
                }
            }
        }

        return nRet;
    }
}