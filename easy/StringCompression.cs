//https://leetcode.com/problems/string-compression/description/

using System.Collections.Generic;

public class StringCompressionDemo {
    public int Compress(char[] chars) {
        
        List<char> comp = new List<char>();

        char oldchar = 'a';
        int count = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            if (i == 0)
            {
                oldchar = chars[i];
                count++;

                if (chars.Length == 1)
                    comp.Add(oldchar);

                continue;
            }

            if (i == chars.Length - 1)
            {
                if (chars[i] == oldchar)
                {
                    count++;
                    comp.Add(oldchar);

                    if (count != 1)
                    {
                        char[] charCount = count.ToString().ToCharArray();
                        foreach (char c in charCount)
                            comp.Add(c);
                    }
                }
                else
                {
                    comp.Add(oldchar);

                    if (count != 1)
                    {
                        char[] charCount = count.ToString().ToCharArray();
                        foreach (char c in charCount)
                            comp.Add(c);
                    }

                    comp.Add(chars[i]);

                    break;
                }
            }

            if (chars[i] == oldchar)
                count++;
            else
            {
                comp.Add(oldchar);

                if (count != 1)
                {
                    char[] charCount = count.ToString().ToCharArray();
                    foreach (char c in charCount)
                        comp.Add(c);
                }

                oldchar = chars[i];
                count = 1;
            }
        }

        for (int i = 0; i < comp.Count; i++)
            chars[i] = comp[i];

        return comp.Count;
    }
}