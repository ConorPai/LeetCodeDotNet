//https://leetcode.com/problems/partition-labels/description/

using System.Collections.Generic;
using System.Text;

public class PartitionLabelsDemo {
    public IList<int> PartitionLabels(string S) {
        List<string> parts = new List<string>();
        foreach (char c in S.ToCharArray())
        {
            bool bContain = false;
            for (int i = 0; i < parts.Count; i++)
            {
                if (parts[i].Contains(c.ToString()))
                {
                    bContain = true;
                    for (int j = i + 1; j < parts.Count; j++)
                        parts[i] += parts[j];
                    
                    for (int j = parts.Count - 1; j > i; j--)
                        parts.RemoveAt(j);

                    parts[i] += c.ToString();
                    break;
                }
            }

            if (!bContain)
                parts.Add(c.ToString());
        }

        List<int> ret = new List<int>();
        foreach (string part in parts)
            ret.Add(part.Length);

        return ret;
    }
}