//https://leetcode-cn.com/problems/reorder-log-files/

using System;
using System.Collections.Generic;
using System.Linq;

public class ReorderLogFilesDemo {
    public string[] ReorderLogFiles(string[] logs) {
        List<string> list = new List<string>();
            List<string> listn = new List<string>();
            foreach (string s in logs)
            {
                String[] split1 = s.Split(' ');
                long l1;
                bool digit1 = long.TryParse(split1[1], out l1);
                
                if (split1[1].All(Char.IsDigit))
                {
                    listn.Add(s);
                }
                else
                {
                    list.Add(s);
                }
            }

           
            list.Sort(delegate (string x, string y)
            {
                int result;
                String[] split1 = x.Split(' ');
                String[] split2 = y.Split(' ');
                
                String s1 = x.Substring(x.IndexOf(' ') + 1);
                String s2 = y.Substring(y.IndexOf(' ') + 1);
                
                result = s1.CompareTo(s2);

                if (result == 0)
                {
                    result= x.CompareTo(y);
                }
                return result;
            });

            return list.Concat(listn).ToList().ToArray();
        }
}